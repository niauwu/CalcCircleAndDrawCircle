# CalcCircleAndDrawCircle
計算圓的半徑、直徑、圓周長、面積，然後畫圓 calc circle radius diameter circumference area then draw circle

![image](https://github.com/niauwu/CalcCircleAndDrawCircle/blob/master/UI.png)

        /*已知半徑，求直徑、圓周長、面積*/
        public void setRadius(decimal radius)
        {
            this.Radius = radius;
            this.Diameter = 2 * this.Radius;
            this.Circumference = 2 * this.Radius * Math.Round(PI(), 2);
            this.Area = PI() * this.Radius * this.Radius;
        }

        /*已知直徑，求半徑、圓周長、面積*/
        public void setDiameter(decimal diameter)
        {
            this.Diameter = diameter;
            this.Radius = this.Diameter / 2;
            this.Circumference = 2 * this.Radius * PI();
            this.Area = PI() * this.Radius * this.Radius;
        }

        /*已知圓周長，求半徑、直徑、面積*/
        public void setCircumference(decimal circumfereence)
        {
            this.Circumference = circumfereence;
            this.Radius = this.Circumference / 2 / PI();
            this.Diameter = this.Radius * 2;
            this.Area = PI() * this.Radius * this.Radius;
        }

        /*已知面積，求半徑、直徑、圓周長*/
        public void setArea(decimal area)
        {
            this.Area = area;
            this.Radius = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(this.Area / PI())));
            this.Diameter = 2 * this.Radius;
            this.Circumference = 2 * this.Radius * PI();
        }
