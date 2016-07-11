namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    using System.Text;

    public class Tank : Machine, ITank, IMachine
    {
        private const int InitialHealthPoints = 100;
        private const int AttackPointsChange = 40;
        private const int DefensePoitnsChange = 30;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleDefenseMode(); 
        }
 
        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.AttackPoints -= AttackPointsChange;
                this.DefensePoints += DefensePoitnsChange;
            }
            else
            {
                this.AttackPoints += AttackPointsChange;
                this.DefensePoints -= DefensePoitnsChange;
            }
        }

        public override string ToString()
        {
            var baseStr = base.ToString();
            var tankInfo = new StringBuilder();
            tankInfo.Append(baseStr);
            tankInfo.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

            return tankInfo.ToString();
        }
    }
}
