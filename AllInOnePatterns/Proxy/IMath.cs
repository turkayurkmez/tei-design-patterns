using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IMath
    {
        public double Add(double x, double y );
        public double Subtract(double x, double y);
        public double Multiply(double x, double y);


    }

    public class RealMath : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
          
        }

        public double Subtract(double x, double y)
        {
            return x - y;
         
        }
    }

    public class ProxyMath : IMath
    {
        private static int requestCount = 0;
        private readonly RealMath realMath;
        public ProxyMath()
        {
            realMath = new RealMath();
        }

        public double Add(double x, double y)
        {
            requestCount++;
            if (check())
            {
                return realMath.Add(x, y);
            }
            throw new InvalidOperationException("Bu nesneye nah ulaşırsın!");
           
        }

        

        public double Multiply(double x, double y)
        {
         return realMath.Multiply(x, y);
        }

        public double Subtract(double x, double y)
        {
          return realMath.Subtract(x, y);
        }

        private bool check()
        {
            return requestCount <= 5;
        }
    }
}
