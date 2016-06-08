namespace _01._3DPoint
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> pointsList;

        public Path(params Point3D[] points)
        {
            this.pointsList = new List<Point3D>(points);
        }

        public List<Point3D> PointPathList
        {
            get
            {
                return this.pointsList;
            }

            set
            {
                this.pointsList = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.pointsList.Add(point);
        }

        public void ClearPath()
        {
            this.pointsList.Clear();
        }

        public override string ToString()
        {
            var pathList = new StringBuilder();

            foreach (var point in this.PointPathList)
            {
                pathList.Append("< " + point + ">, ");
            }

            return pathList.ToString().TrimEnd(',');
        }
    }
}
