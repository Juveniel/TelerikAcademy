namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarMachines.Common;
    using WarMachines.Interfaces;
   
    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;                
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Pilot name");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNull(machine, "Pilot machine");
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);
            var machinesCount = this.machines.Count;
            var setPlural = machinesCount == 1 ? "machine" : "machines";
            var setCount = machinesCount > 0 ? machinesCount.ToString() : "no";

            var pilotInfo = new StringBuilder();
            pilotInfo.AppendLine(string.Format("{0} - {1} {2}", this.Name, setCount, setPlural));

            foreach (var machine in sortedMachines)
            {
                pilotInfo.AppendLine(machine.ToString());
            }

            return pilotInfo.ToString().Trim();
        }
    }
}
