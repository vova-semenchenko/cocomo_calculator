using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCOMO_MODEL
{
    public class COCOCMO_Model
    {
        private static double[][] modelTable = new double[3][];
        private readonly int codeSize = 0;
        private readonly ProjectType projectType;
        public COCOCMO_Model(int codeSize, ProjectType projectType)
        {
            modelTable[0] = new[] { 2.4, 1.05, 2.5, 0.38 };
            modelTable[1] = new[] { 3.0, 1.12, 2.5, 0.35 };
            modelTable[2] = new[] { 3.6, 1.20, 2.5, 0.32 };

            this.codeSize = codeSize;
            this.projectType = projectType;
        }

        public double GetEfforts() => 
            modelTable[(int)projectType][0] * Math.Pow(codeSize, modelTable[(int)projectType][1]);

        public double GetTimeToDevelop() => 
            modelTable[(int)projectType][2] * Math.Pow(GetEfforts(), modelTable[(int)projectType][3]);


        public double GetPersonsToDevelop() => 
            GetEfforts() / GetTimeToDevelop();

        public double GetProductivity() => 
            codeSize / GetEfforts();
    }
}
