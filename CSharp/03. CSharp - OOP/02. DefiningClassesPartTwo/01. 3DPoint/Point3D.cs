namespace _01._3DPoint
{
    using System.Text;

    public struct Point3D
    {       
        private static readonly Point3D PointSystemStart = new Point3D(0, 0, 0);

        public Point3D(double pointX, double pointY, double pointZ)
        {
            this.PointX = pointX;
            this.PointY = pointY;
            this.PointZ = pointZ;
        }

        public double PointX { get; set; }

        public double PointY { get; set; }

        public double PointZ { get; set; }

        public override string ToString()
        {
            var pointPrinter = new StringBuilder();

            pointPrinter.AppendFormat(
                "{0:F2} | {0:F2} | {0:F2}", 
                this.PointX.ToString(), 
                this.PointY.ToString(),
                this.PointZ.ToString());

            return pointPrinter.ToString();
        }
    }
}
