using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._24
{
    class ShapeChecker
    {
        public bool CanCircleFitInTriangle(double a)
        {
            double rCircle = a * Math.Sqrt(3) / 6;
            double rInscribedCircle = a * Math.Sqrt(3) / 6;
            return rCircle <= rInscribedCircle;
        }

        public bool CanTriangleFitInCircle(double a)
        {
            double rTriangle = a * Math.Sqrt(3) / 3;
            double rCircumscribedCircle = a * Math.Sqrt(3) / 3;
            return rTriangle <= rCircumscribedCircle;
        }
    }
}
