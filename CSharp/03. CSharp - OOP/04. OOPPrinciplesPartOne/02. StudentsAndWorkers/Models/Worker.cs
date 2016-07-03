namespace StudentsAndWorkers.Models
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary cannot be negative!");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours cannot be negative!");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.workHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format(
                "Worker: {0} | Week Salary: {1} | Work hours per day: {2} | Money per hour: {3:F2}",
                this.GetFullName(), 
                this.weekSalary, 
                this.workHoursPerDay,
                this.MoneyPerHour());
        }
    }
}
