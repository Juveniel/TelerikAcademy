using System.Linq;
using System.Runtime.CompilerServices;
using School.Contracts;

namespace School.Common
{
    using System;
    using System.Collections.Generic;

    public static class Validator
    {
        public static void CheckIfNull(object value, string message)
        {
            if (value == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void ValidateIntRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static void CheckExisting<T>(ICollection<T> collection, object value, string message)
        {
            if (collection.Contains((T)value))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckNotExisting<T>(ICollection<T> collection, object value, string message)
        {
            if (!collection.Contains((T)value))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckStudentId<T>(ICollection<T> collection, IStudent value, string message) where T : IStudent
        {
            if (collection.Any(s => s.Id == value.Id))
            {
                throw new ArgumentException(message);
            }
        } 
    }
}
