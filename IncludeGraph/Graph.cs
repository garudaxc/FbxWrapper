using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IncludeGraph
{    

    class Node
    {
        public enum Color
        {
            Black,
            White,
            Red
        }


        public object data { get; set; }

        List<Edge> income = new List<Edge>();
        List<Edge> outcome = new List<Edge>();

        public List<Edge> InCome {
            get
            {
                return income;
            }
        }

        public List<Edge> OutCome
        {
            get
            {
                return outcome;
            }
        }

        public Color color { get; set; }
                
    }

    class Edge
    {
        public Node from { get; set; }
        public Node to { get; set; }

        public bool visited { get; set; }
    }

 
    class Graph
    {
        Node[] nodes;
        List<Edge> edges;
        string path_;

        public void Build (string path)
        {
            path = path.Replace('\\', '/');
            if (!path.EndsWith("/"))
            {
                path += '/';
            }
            path_ = path;

            string[] files = Directory.GetFiles(path, "*.h", SearchOption.AllDirectories);

            files = Array.ConvertAll(files, (f) => f.Replace('\\', '/'));

            //Array.ForEach(files, f => Log.Info(f));
            Log.Info("files {0}", files.Length);

            nodes = Array.ConvertAll(files, (f) =>
            {
                Node n = new Node();
                n.data = f;
                return n;
            });

            edges = new List<Edge>();

            string pattern = @"#include\s+[<""](.+)[>""]";
            Regex rex = new Regex(pattern);

            for (int i = 0; i < files.Length; i++)
            {
                string text = File.ReadAllText(files[i]);
                var match = rex.Matches(text);

                Log.Info("match {0}", files[i]);
                foreach(Match m in match)
                {
                    if (m.Groups.Count != 2 || m.Groups[0].Captures.Count != 1)
                    {
                        Log.Error("{0} match {1} error", files[i], m.Value);
                        continue;
                    }

                    string infile = m.Groups[1].Captures[0].Value;

                    infile = infile.Replace('\\', '/');
                    infile = path + infile;

                    int index = Array.FindIndex(files, (f) => f.Equals(infile));
                    Log.Info("infile {0} find index {1}", infile, index);
                    if (index == -1)
                    {
                        continue;
                    }

                    Edge edge = new Edge();
                    edge.from = nodes[index];
                    edge.to = nodes[i];
                    edges.Add(edge);

                    nodes[index].OutCome.Add(edge);
                    nodes[i].InCome.Add(edge);
                }
            }
        }

        bool FindCircle(Node node, Stack<Node> stack)
        {
            if (stack.Contains(node))
            {
                stack.Push(node);
                return true;
            }

            stack.Push(node);
            for (int i = 0; i < node.OutCome.Count; i++ )
            {
                if (FindCircle(node.OutCome[i].to, stack))
                {
                    return true;
                }
            }
            stack.Pop();

            return false;
        }

        public void FindCircle()
        {
            Stack<Node> stack = new Stack<Node>();

            Array.ForEach(nodes, (node) =>
            {
                Log.Info("visit node {0}", node.data);
                if (FindCircle(node, stack))
                {
                    Log.Info("found circle");
                    foreach (Node n in stack)
                    {
                        Log.Info("\t{0}", n.data);
                    }

                    Node top = stack.Pop();
                    Node top2 = stack.Pop();
                    foreach(var e in top2.OutCome)
                    {
                        if (e.to == top)
                        {
                            top2.OutCome.Remove(e);
                            top.InCome.Remove(e);
                            break;
                        }
                    }
                    stack.Clear();
                }
            });            
        }


        public void Sort()
        {           
            Array.ForEach(nodes, (node) => node.color = Node.Color.Black);
            edges.ForEach((e) => e.visited = false);
            
            List<Node> orderd = new List<Node>();

            bool done = false;
            while(!done)
            {
                done = true;
                for (int i = 0; i < nodes.Length; i++ )
                {
                    Node node = nodes[i];
                    if (node.color == Node.Color.Red)
                    {
                        continue;
                    }
                    if (node.InCome.Count == 0 ||
                        node.InCome.FindIndex((e) => !e.visited) == -1)
                    {
                        done = false;
                        for (int j = 0; j < node.OutCome.Count; j++)
                        {
                            node.OutCome[j].visited = true;
                        }
                        node.color = Node.Color.Red;
                        orderd.Add(node);
                    }
                    //Log.Info("visit node {0}", node.data);
                }
            }
            
            if (orderd.Count != nodes.Length)
            {
                Log.Error("ordered node not match node count {0} total {1}", orderd.Count, nodes.Length);
                return;
            }

            Log.Info("ordered");
            orderd.ForEach((node) =>
            {
                int index = Array.IndexOf(nodes, node);
                Log.Info("{0} {1}", index, node.data);
            });

            Log.Info("");
            int len = path_.Length;
            orderd.ForEach((node) =>
            {
                string file = ((string)node.data).Substring(len);
                Log.Info("%include \"{0}\"", file);
            });
        }



    }
}
