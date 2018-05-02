using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcCircleAndDrawCircle
{
    class Circle
    {
        public decimal Radius, Diameter, Circumference, Area;

        public void setRadius(decimal radius)
        {
            this.Radius = radius;
            this.Diameter = 2 * this.Radius;
            this.Circumference = 2 * this.Radius * Math.Round(PI(), 2);
            this.Area = PI() * this.Radius * this.Radius;
        }

        public void setDiameter(decimal diameter)
        {
            this.Diameter = diameter;
            this.Radius = this.Diameter / 2;
            this.Circumference = 2 * this.Radius * PI();
            this.Area = PI() * this.Radius * this.Radius;
        }

        public void setCircumference(decimal circumfereence)
        {
            this.Circumference = circumfereence;
            this.Radius = this.Circumference / 2 / PI();
            this.Diameter = this.Radius * 2;
            this.Area = PI() * this.Radius * this.Radius;
        }

        public void setArea(decimal area)
        {
            this.Area = area;
            this.Radius = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(this.Area / PI())));
            this.Diameter = 2 * this.Radius;
            this.Circumference = 2 * this.Radius * PI();
        }

        static decimal PI()
        {
            // Returns PI
            return 2 * F(1);
        }

        static decimal F(int i)
        {
            // Receives the call number
            if (i > 60)
            {
                // Stop after 60 calls
                return i;
            }
            else
            {
                // Return the running total with the new fraction added
                return 1 + (i / (1 + (2.0m * i))) * F(i + 1);
            }
        }
    }
}
