 using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter, IMachine
    {
        private const int InitialHealthPoint = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode) 
            : base(name, attackPoints, defensePoints, InitialHealthPoint)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var baseStr = base.ToString();
            var fighterInfo = new StringBuilder();
            fighterInfo.Append(baseStr);
            fighterInfo.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));

            return fighterInfo.ToString();
        }
    }
}
