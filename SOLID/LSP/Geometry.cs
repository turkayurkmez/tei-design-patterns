using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Geometry
    {

        //Problem: Kare ve Dikdörtgen sınıfları arasında bir yanlış miras ilişkisi vardır.
        public IShape GetRectangle(double unit1, double? unit2 = null)
        {
            //bazı işlemler yapılır....
            if (unit2 == null)
                return new Square() { EdgeLength = unit1};
            else
                return new Rectangle() { Width= unit1, Height = unit2.Value};
            
        }
    }


    public interface IShape
    {
        double GetArea();
    }
    public class Rectangle : IShape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public double GetArea() => Width * Height;

    }

    public class Square :IShape //: Rectangle
    {
        public double EdgeLength { get; set; }

        public double GetArea() => EdgeLength * EdgeLength;

    }
}
