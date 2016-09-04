namespace Methods.Contracts
{
    using System;

    public interface IStudent
    {
        string FirstName { get; set; }

        string Lastname { get; set; }
 
        DateTime DateOfBirth { get; set; }

        string PlaceOfBirth { get; set; }

        string PersonalityTraits { get; set; }

        bool IsOlderThan(IStudent student);
    }
}