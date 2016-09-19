﻿namespace Exceptions.Models
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {                                                
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;                
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grade must be a positive number.");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;                
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("minGrade must be a positive number");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;                
            }

            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentException("maxGrade must be bigger than minGrade");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;                
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Comments cannot be empty");
                }

                this.comments = value;
            }
        }
    }
}
