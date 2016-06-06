namespace _01.DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
  
    public class GSM
    {
        private string model;
        private string manufacturer;   
        private string owner;
        private double? price;
        private List<Call> callHistory;

        public GSM()
        {
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, null, null)
        {
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
        }

        public static GSM IPhone4S
        {
            get
            {
                return new GSM("IPhone4S", "Apple");
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be null or empty!");
                }
                else
                {
                    this.model = value;
                }      
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot be null or empty!");
                }
                else
                {
                    this.manufacturer = value;
                }                
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value == null || value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException();
                }                
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Owner cannot be empty!");
                }
                else
                {
                    this.owner = value;
                }                
            }
        }

        public void AddCall(DateTime dateTime, string phoneNumber, TimeSpan duration)
        {
            var call = new Call(dateTime, phoneNumber, duration);
            this.callHistory.Add(call);
        }

        public void RemoveCall()
        {
            this.PrintCallHistory();

            Console.WriteLine("Enter the index of the call u would like to remove: ");
            int callToRemove = int.Parse(Console.ReadLine());

            if (this.callHistory.ElementAtOrDefault(callToRemove) != null)
            {
                this.callHistory.RemoveAt(callToRemove);
                Console.WriteLine("Call log has been removed");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        public string CalculateCallPrice(double fixedPricePerMinute)
        {
            double callCost = 0;

            foreach (var call in this.callHistory)
            {
                callCost += fixedPricePerMinute * call.Duration.Minutes;
            }

            string result = string.Format("Calls cost: {0:F2}", callCost);

            return result;
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void PrintCallHistory()
        {
            Console.WriteLine("CALL HISTORY:");

            if (this.callHistory.Count == 0)
            {
                Console.WriteLine("Call log is empty.");
            }
            else
            {
                int counter = 0;

                foreach (var call in this.callHistory)
                {
                    Console.WriteLine(
                        "{0}) Number: {1}, Date: {2}, Duration: {3}", 
                        counter, 
                        call.DialedNumber, 
                        call.DateTime, 
                        call.Duration);

                    counter++;
                }
            }
        }

        public override string ToString()
        {
            var gsmCharacteristics = new StringBuilder();

            gsmCharacteristics.Append("GSM Characteriscits:").AppendLine();
            gsmCharacteristics.AppendLine("===============================");
            gsmCharacteristics.Append("Model: ").Append(this.model).AppendLine();
            gsmCharacteristics.Append("Manufacturer: ").Append(this.manufacturer).AppendLine();
            gsmCharacteristics.Append("Price: ").AppendFormat("{0:F2}", this.price.ToString()).AppendLine();
            gsmCharacteristics.Append("Owner: ").Append(this.Owner).AppendLine();
            gsmCharacteristics.AppendLine("===============================");

            if (Battery != null)
            {
                gsmCharacteristics.AppendLine(Battery.ToString());
            }

            if (Display != null)
            {
                gsmCharacteristics.AppendLine(Display.ToString());
            }

            return gsmCharacteristics.ToString();
        }
    }
}
