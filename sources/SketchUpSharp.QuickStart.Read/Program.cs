using System;
using static SketchUpSharp.Methods;

namespace SketchUpSharp.QuickStart.Read
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            SUInitialize();

            nuint major, minor;
            SUGetAPIVersion(&major, &minor);
            Console.WriteLine($"SU API Version");
            Console.WriteLine($"  Major = {major}");
            Console.WriteLine($"  Minor = {minor}");

            SUResult res;
            SUModelRef model;
            var path1 = System.Text.Encoding.ASCII.GetBytes("model.skp\0");
            var path2 = (sbyte[])(Array)path1;
            fixed (sbyte* path3 = path2)
            {
                res = SUModelCreateFromFile(&model, path3);
            }

            SUEntitiesRef entities;
            res = SUModelGetEntities(model, &entities);

            // Get all the faces from the entities object
            nuint faceCount;
            res = SUEntitiesGetNumFaces(entities, &faceCount);
            if (faceCount > 0)
            {
                var faces = new SUFaceRef[faceCount];
                fixed (SUFaceRef* faceRef = faces)
                {
                    res = SUEntitiesGetFaces(entities, faceCount, faceRef, &faceCount);
                }

                // Get all the edges in this face
                for (nuint i = 0; i < faceCount; i++)
                {
                    Console.WriteLine($"Face {i + 1}:");
                    nuint edgeCount;
                    res = SUFaceGetNumEdges(faces[i], &edgeCount);
                    if (edgeCount > 0)
                    {
                        var edges = new SUEdgeRef[edgeCount];
                        fixed (SUEdgeRef* edgeRef = edges)
                        {
                            res = SUFaceGetEdges(faces[i], edgeCount, edgeRef, &edgeCount);
                        }

                        // Get the vertex positions for each edge
                        for (nuint j = 0; j < edgeCount; j++)
                        {
                            SUVertexRef startVertex, endVertex;
                            res = SUEdgeGetStartVertex(edges[j], &startVertex);
                            res = SUEdgeGetEndVertex(edges[j], &endVertex);

                            SUPoint3D start, end;
                            res = SUVertexGetPosition(startVertex, &start);
                            res = SUVertexGetPosition(endVertex, &end);
                            // Now do something with the point data

                            Console.WriteLine($"  Edge {j + 1}:");
                            Console.WriteLine($"    Start: {start.x},{start.y},{start.z}");
                            Console.WriteLine($"    End: {end.x},{end.y},{end.z}");
                        }
                    }
                }
            }

            // Get model name
            SUStringRef name;
            res = SUStringCreate(&name);
            res = SUModelGetName(model, &name);
            nuint name_length;
            res = SUStringGetUTF8Length(name, &name_length);
            var nameUtf8 = new sbyte[name_length + 1];
            fixed (sbyte* nameUtf8Ref = nameUtf8)
            {
                res = SUStringGetUTF8(name, name_length + 1, nameUtf8Ref, &name_length);
            }
            res = SUStringRelease(&name);

            res = SUModelRelease(&model);
            SUTerminate();
        }
    }
}
