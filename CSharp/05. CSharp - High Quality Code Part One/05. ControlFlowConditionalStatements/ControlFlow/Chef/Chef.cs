namespace Chef
{
    using System;
    using Models;

    public class Chef
    {              
        public Bowl Cook()
        {
            var potato = this.GetPotato();
            var carrot = this.GetCarrot();

            var processedPotato = potato.Process();
            var processedCarrot = carrot.Process();

            var bowl = this.GetBowl();

            bowl.Add(processedPotato);
            bowl.Add(processedCarrot);

            return bowl;
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }

        private Potato GetPotato()
        {
            throw new NotImplementedException();
        }
    }
}
