using System;
using System.Collections.Generic;
using System.Text;
using Fbx;

namespace test
{

    class Log
    {
        public static void Info(object s)
        {
            Console.WriteLine(s);
        }

        public static void Error(object s)
        {
            Console.WriteLine(s);
        }
    }


    class Program
    {

        void PrintDoubleArray(DoubleArray array, int count)
        {
            if (count == 4)
            {
                string s = string.Format("({0} {1} {2} {3})",
                    array.getitem(0),
                    array.getitem(1),
                    array.getitem(2),
                    array.getitem(3));
                Log.Info(s);
            }
        }

        void PrintAttribute(FbxNodeAttribute attri)
        {
            Log.Info("attri " + attri.GetName());
            Log.Info("attri type " + Enum.GetName(typeof(FbxNodeAttribute.EType), attri.GetAttributeType()));
            //attri.is

            if (attri.GetAttributeType() == FbxNodeAttribute.EType.eMesh)
            {
                Type t = attri.GetType();
                Log.Info("type name " + t.Name);

                FbxMesh mesh = attri.GetNode().GetMesh();
                //FbxMesh mesh = attri as FbxMesh;
                if (mesh == null)
                {
                    Log.Error("convert mesh failed!");
                    return;
                }

                //FbxMesh mesh;
                //FbxLayerElementUV uv = mesh.GetElementUV();

                //uv.GetDirectArray()

                FbxLayerElementNormal normal = mesh.GetElementNormal();
                DirectArrayFbxVector4 array = normal.GetDirectArray();

                Log.Info("normal count " + array.GetCount());
                for (int i = 0; i < array.GetCount(); i++)
                {
                    FbxVector4 v = array.GetAt(i);
                    SWIGTYPE_p_double data = v.mData;
                    DoubleArray d = DoubleArray.frompointer(data);
                    PrintDoubleArray(d, 4);
                }
            }

        }


        void Run()
        {

            FbxManager manager = FbxManager.Create();
            FbxIOSettings setting = FbxIOSettings.Create(manager, "IOSRoot");
            manager.SetIOSettings(setting);

            FbxImporter impoter = FbxImporter.Create(manager, "");

            bool status = impoter.Initialize(@"D:\develop\FbxWrapper\1.fbx", -1, setting);

            Log.Info(status);

            if (!status)
            {
                return;
            }

            FbxScene scene = FbxScene.Create(manager, "scene1");
            status = impoter.Import(scene);
            Log.Info(status);


            int numTrack = scene.GetSrcObjectCount(FbxAnimStack.ClassId);
            Log.Info("num stack " + numTrack);

            FbxObject obj = scene.GetSrcObject(FbxAnimStack.ClassId, 0);
            
            FbxAnimStack stack = FbxAnimStack.Cast(obj);
            if (stack == null)
            {
                Log.Error("can not get anim stack!");
                return;
            }

            FbxCriteria cri = FbxCriteria.ObjectTypeStrict(FbxAnimLayer.ClassId);
            int numLayer = stack.GetMemberCount(cri);
            Log.Info("anim layer count : " + numLayer);

             FbxAnimLayer layer = null;
            if (numLayer > 0)
            {
                FbxObject layerobj = stack.GetMember(cri, 0);
                layer = FbxAnimLayer.Cast(layerobj);
                if (layer == null)
                {
                    Log.Error("anim layer is null!");
                    return;
                }

                Log.Info("anim layer name " + layer.GetName());
            }
            

            Log.Info("node count " + scene.GetNodeCount());
            for (int i = 0; i < scene.GetNodeCount(); i++)
            {
                FbxNode node = scene.GetNode(i);
                Log.Info("node " + i + " " + node.GetName());

                if (node.LclTranslation.IsAnimated(layer))
                {
                    FbxAnimCurveNode curveNode = node.LclTranslation.GetCurveNode(layer);
                    if (curveNode == null)
                    {
                        Log.Error("curve node is null");                        
                    }
                    else
                    {
                        for (int c = 0; c < curveNode.GetCurveCount(0); c++)
                        {
                            FbxAnimCurve curve = curveNode.GetCurve(0, (uint)c);
                            if (curve != null)
                            {
                                Log.Info("curve " + curve.GetName());
                                Log.Info("key count " + curve.KeyGetCount());
                                FbxAnimCurveKey key = curve.KeyGet(0);
                                FbxTime t = key.GetTime();
                                Log.Info("key " + t.GetTimeString() + " value " + key.GetValue());
                            }
                        }
                    }
                }
                


                if (node.GetNodeAttribute() != null)
                {
                    Log.Info("got attribu");
                    FbxNodeAttribute att = node.GetNodeAttribute();
                    PrintAttribute(att);
                }
                else
                {

                    Log.Info("att count " + node.GetNodeAttributeCount());
                    for (int j = 0; j < node.GetNodeAttributeCount(); j++)
                    {
                        FbxNodeAttribute att = node.GetNodeAttributeByIndex(j);
                        PrintAttribute(att);
                    }
                }

                FbxVector4 rot = node.GetPostRotation(FbxNode.EPivotSet.eSourcePivot);
                FbxQuaternion q;

            }
        }


        static void Main(string[] args)
        {
            
            Program pro = new Program();
            pro.Run();
        }


    }
}
