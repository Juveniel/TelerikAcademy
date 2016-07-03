namespace BankAccounts.Models.Customers
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.GetType().Name, this.name);
        }
    }
}
