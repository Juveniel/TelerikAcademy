namespace _01.DefineClass
{
    using System;
    using System.Text;

    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    public class Battery
    {
        private string batteryModel;
        private BatteryType? batteryType;
        private int? hoursIdle;
        private int? hoursTalked;

        public Battery()
        {
        }

        public Battery(string batteryModel) : this(batteryModel, null, null, null)
        {
        }

        public Battery(string batteryModel, BatteryType? batteryType, int? hoursIdle, int? hoursTalked)
        {
            this.BatteryModel = batteryModel;
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalked = hoursTalked;
        }

        public BatteryType? BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.batteryModel = value;
                }              
            }
        }
        
        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value == null || value >= 0) 
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? HoursTalked
        {
            get
            {
                return this.hoursTalked;
            }

            set
            {
                if (value == null || value >= 0)
                {
                    this.hoursTalked = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public override string ToString()
        {
            var batteryCharacteristics = new StringBuilder();
            batteryCharacteristics.AppendLine("Battery Characteristics: ");
            batteryCharacteristics.AppendLine("===============================");
            batteryCharacteristics.Append("Battery model: ").Append(this.batteryModel).AppendLine();
            batteryCharacteristics.Append("Battery type:").Append(this.batteryType.ToString()).AppendLine();
            batteryCharacteristics.Append("Battery hours idle: ").Append(this.hoursIdle.ToString()).AppendLine();
            batteryCharacteristics.Append("Battery hours talked: ").Append(this.hoursTalked.ToString()).AppendLine();
            batteryCharacteristics.AppendLine("===============================");

            return batteryCharacteristics.ToString();
        }
    }
}
