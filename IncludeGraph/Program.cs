using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncludeGraph
{

    class Log
    {
        public static StreamWriter sw;

        public static void Error(string fmt,params Object[]args)
        {
            string str = string.Format(fmt, args);
            Console.WriteLine(str);
            if (sw != null)
            {
                sw.WriteLine(str);
            }
        }

        public static void Info(string fmt, params Object[] args)
        {
            string str = string.Format(fmt, args);
            Console.WriteLine(str);
            if (sw != null)
            {
                sw.WriteLine(str);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = File.CreateText("log.txt");
            Log.sw = file;
            
            Graph graph = new Graph();
            //graph.Build(@"d:\test\asmtest\asmtest\");
            graph.Build(@"..\header\");
            graph.FindCircle();
            //Log.Info("find circle again");
            //graph.FindCircle();
            graph.Sort();

            file.Flush();
            file.Close();
        }
    }
}
