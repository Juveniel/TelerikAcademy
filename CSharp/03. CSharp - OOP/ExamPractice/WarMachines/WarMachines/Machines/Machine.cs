namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Common;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {    
                return this.name;                
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Machine name");
                this.name = value;                
            }
        }       

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                Validator.CheckIfNull(value, "Machine pilot");
                this.pilot = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return this.targets;                
            }
        }

        public void Attack(string target)
        {
            Validator.CheckIfNull(target, "Target");
            this.Targets.Add(target);
        }

        public override string ToString()
        {
            var targetsAsString = this.Targets.Count > 0 
                ? string.Join(", ", this.targets) 
                : "None" ;

            var machineInfo = new StringBuilder();
            machineInfo.AppendLine(string.Format("- {0}", this.Name));
            machineInfo.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            machineInfo.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            machineInfo.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            machineInfo.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            machineInfo.AppendLine(string.Format(" *Targets: {0}", targetsAsString));

            return machineInfo.ToString();
        }
    }
}
