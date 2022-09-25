using System.Collections.Generic;
using System.Linq;

namespace Modulation
{
    public static class CrossCorrelation
    {
        public static double[] Run(double[] n, double[] m)
        {
            var correlation = new List<double>();
            double res = 0;
            for (var i = 0; i < m.Length - n.Length; i++)
            {
                res += n.Select((t, j) => t * m[i + j]).Sum();
                correlation.Add(res / n.Length);
                res = 0;
            }

            return correlation.ToArray();
        }


        public static double FindMaxMs(double[] cor, double sampRate) => cor.ToList().IndexOf(cor.Max()) / sampRate;
    }
}
