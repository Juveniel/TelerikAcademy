using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace SolarSystem
{
    public sealed class Sphere : Surface
    {
        private static readonly PropertyHolder<double, Sphere> _radiusProperty =
            new PropertyHolder<double, Sphere>("Radius", 1.0, OnGeometryChanged);

        public double Radius
        {
            get
            {
                return _radiusProperty.Get(this);
            }

            set
            {
                _radiusProperty.Set(this, value);                
            }
        }

        private static readonly PropertyHolder<Point3D, Sphere> PositionProperty =
            new PropertyHolder<Point3D, Sphere>("Position", new Point3D(0,0,0), OnGeometryChanged);

        public Point3D Position
        {
            get
            {
                return PositionProperty.Get(this);
            }

            set
            {
                PositionProperty.Set(this, value);
            }
        }

        private double _radius;
        private Point3D _position;

        private Point3D GetPosition(double angle, double y)
        {
            var r = _radius * Math.Sqrt(1 - y * y);
            var x = r * Math.Cos(angle);
            var z = r * Math.Sin(angle);

            return new Point3D(_position.X + x, _position.Y + _radius*y, _position.Z + z);
        }

        private Vector3D GetNormal(double angle, double y)
        {
            return (Vector3D) GetPosition(angle, y);
        }

        private static Point GetTextureCoordinate(double angle, double y)
        {
            var map = new Matrix();
            map.Scale(1 / (2 * Math.PI), -0.5);

            var p = new Point(angle, y);
            p = p * map;

            return p;
        }

        protected override Geometry3D CreateMesh()
        {
            _radius = Radius;
            _position = Position;

            const int angleSteps = 32;
            const double minAngle = 0;
            const double maxAngle = 2 * Math.PI;
            const double dAngle = (maxAngle-minAngle) / angleSteps;

            const int ySteps = 32;
            const double minY = -1.0;
            const double maxY = 1.0;
            const double dy = (maxY - minY) / ySteps;

            var mesh = new MeshGeometry3D();

            for (var yi = 0; yi <= ySteps; yi++)
            {
                var y = minY + yi * dy;

                for (var ai = 0; ai <= angleSteps; ai++)
                {
                    var angle = ai * dAngle;

                    mesh.Positions.Add(GetPosition(angle, y));
                    mesh.Normals.Add(GetNormal(angle, y));
                    mesh.TextureCoordinates.Add(GetTextureCoordinate(angle, y));
                }
            }

            for (var yi = 0; yi < ySteps; yi++)
            {
                for (var ai = 0; ai < angleSteps; ai++)
                {
                    var a1 = ai;
                    var a2 = (ai + 1);
                    var y1 = yi * (angleSteps + 1);
                    var y2 = (yi + 1) * (angleSteps + 1);

                    mesh.TriangleIndices.Add(y1 + a1);
                    mesh.TriangleIndices.Add(y2 + a1);
                    mesh.TriangleIndices.Add(y1 + a2);

                    mesh.TriangleIndices.Add(y1 + a2);
                    mesh.TriangleIndices.Add(y2 + a1);
                    mesh.TriangleIndices.Add(y2 + a2);
                }
            }

            mesh.Freeze();
            return mesh;
        }
    }
}
