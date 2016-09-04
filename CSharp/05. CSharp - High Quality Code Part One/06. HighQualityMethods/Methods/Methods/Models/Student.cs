namespace Methods.Models
{
    using System;
    using Contracts;

    public class Student : IStudent
    {
        private string firstName;
        private string lastName;

        public Student(
            string firstName, 
            string lastName,
            string dateOfBirth, 
            string placeOfBirth = null,
            string personalityTraits = null)
        {
            DateTime parsedDayOfBirth;
            if (!DateTime.TryParse(dateOfBirth, out parsedDayOfBirth))
            {
                throw new FormatException("Incorrect Date format! Suggest to (15.04.1999)");
            }

            this.FirstName = firstName;
            this.Lastname = lastName;
            this.DateOfBirth = parsedDayOfBirth;
            this.PlaceOfBirth = placeOfBirth;
            this.PersonalityTraits = personalityTraits;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;                
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty!");
                }

                this.firstName = value;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        public string PersonalityTraits { get; set; }
    
        public bool IsOlderThan(IStudent otherStudent)
        {
            if (otherStudent == null)
            {
                throw new ArgumentException("Student is null");
            }

            var isOlder = this.DateOfBirth > otherStudent.DateOfBirth;

            return isOlder;
        }
    }
}
