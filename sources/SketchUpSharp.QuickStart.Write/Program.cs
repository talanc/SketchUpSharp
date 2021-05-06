using System;
using static SketchUpSharp.Methods;

namespace SketchUpSharp.QuickStart.Write
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

            // Create an empty model
            SUModelRef model;
            res = SUModelCreate(&model);

            // Get the entity container of the model
            SUEntitiesRef entities;
            res = SUModelGetEntities(model, &entities);

            // Create a loop input describing the vertex ordering for a face's outer loop
            SULoopInputRef outerLoop;
            res = SULoopInputCreate(&outerLoop);
            for (nuint i = 0; i < 4; i++)
            {
                res = SULoopInputAddVertexIndex(outerLoop, i);
            }

            //const double CONV_MM_INCH = 1 / 25.4;
            const double CONV_M_INCH = 39.3700787;

            // Create the face
            SUFaceRef face;
            SUPoint3D[] vertices = new[]
            {
                new SUPoint3D() { x = 0, y = 0, z = 0},
                new SUPoint3D() { x = 1 * CONV_M_INCH, y = 0, z = 0},
                new SUPoint3D() { x = 1 * CONV_M_INCH, y = 0, z = 1 * CONV_M_INCH},
                new SUPoint3D() { x = 0, y = 0, z = 1 * CONV_M_INCH},
            };
            fixed (SUPoint3D *verticesPtr = vertices)
            {
                res = SUFaceCreate(&face, verticesPtr, &outerLoop);
            }

            // Add the face to the entities
            res = SUEntitiesAddFaces(entities, 1, &face);

            // Save the in-memory model to a file
            var path1 = System.Text.Encoding.UTF8.GetBytes("new_model.skp\0");
            var path2 = (sbyte[])(Array)path1;
            fixed (sbyte* path3 = path2)
            {
                res = SUModelSaveToFileWithVersion(model, path3, SUModelVersion.SUModelVersion_SU2017);
            }

            // Must release the model or there will be memory leaks
            res = SUModelRelease(&model);

            // Always terminate the API when done using it
            SUTerminate();
        }
    }
}
