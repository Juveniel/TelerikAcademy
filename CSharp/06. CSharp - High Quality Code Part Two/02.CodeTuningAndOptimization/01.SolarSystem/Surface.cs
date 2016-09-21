namespace SolarSystem
{
    using System;
    using System.Windows;
    using System.Windows.Media.Media3D;

    public abstract class Surface : ModelVisual3D
    {       
        private static PropertyHolder<Material, Surface> backMaterialProperty =
            new PropertyHolder<Material, Surface>("BackMaterial", null, OnBackMaterialChanged);

        private static PropertyHolder<bool, Surface> visibleProperty =
            new PropertyHolder<bool, Surface>("Visible", true, OnVisibleChanged);

        private static PropertyHolder<Material, Surface> materialProperty =
            new PropertyHolder<Material, Surface>("Material", null, OnMaterialChanged);

        private readonly GeometryModel3D content = new GeometryModel3D();

        protected Surface()
        {
            this.Content = this.content;
            this.content.Geometry = this.CreateMesh();
        }        

        public Material Material
        {
            get
            {
                return materialProperty.Get(this);
            }

            set
            {
                materialProperty.Set(this, value);
            }
        }

        public Material BackMaterial
        {
            get
            {
                return backMaterialProperty.Get(this);
            }

            set
            {
                backMaterialProperty.Set(this, value);
            }
        }

        public bool Visible
        {
            get
            {
                return visibleProperty.Get(this);
            }

            set
            {
                visibleProperty.Set(this, value);
            }
        }

        protected static void OnGeometryChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            ((Surface)sender).OnGeometryChanged();
        }

        protected abstract Geometry3D CreateMesh();
        
        private static void OnMaterialChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            ((Surface)sender).OnMaterialChanged();
        }

        private static void OnBackMaterialChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            ((Surface)sender).OnBackMaterialChanged();
        }

        private static void OnVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            ((Surface)sender).OnVisibleChanged();
        }        

        private void OnMaterialChanged()
        {
            this.SetContentMaterial();
        }

        private void OnBackMaterialChanged()
        {
            this.SetContentBackMaterial();
        }

        private void OnVisibleChanged()
        {
            this.SetContentMaterial();
            this.SetContentBackMaterial();
        }

        private void SetContentMaterial()
        {
            this.content.Material = this.Visible ? this.Material : null;
        }

        private void SetContentBackMaterial()
        {
            this.content.BackMaterial = this.Visible ? this.BackMaterial : null;
        }

        private void OnGeometryChanged()
        {
            this.content.Geometry = this.CreateMesh();
        }                
    }
}
