using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

using Autodesk.Dynamo.MeshToolkit;

namespace ZeroTouchMeshLibrary
{
    public class MeshToRevitStructure
    {
        public static void ConvertMeshToRevitStructure(Mesh inputMesh)
        {
            var doubleList = inputMesh.EdgesAsSixNumbers;

            int counter = 0;
            var temp = new double[6];
            foreach (var d in doubleList)
            {
                temp[counter%6] = d;

                ++counter;

                if (counter%6 != 0)
                    continue;

                double sp_x = temp[0];
                double sp_y = temp[1];
                double sp_z = temp[2];

                double ep_x = temp[3];
                double ep_y = temp[4];
                double ep_z = temp[5];

                // make a Revit element
                //Autodesk.Revit.DB.Transform.CreateTranslation(sp_x, sp_y, sp_z);
            }

        }
    }
}
