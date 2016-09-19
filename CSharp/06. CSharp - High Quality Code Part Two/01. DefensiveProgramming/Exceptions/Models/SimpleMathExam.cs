namespace Exceptions.Models
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 2;

        private const int BadGradeProblemsCount = 0;
        private const int AverageGradeProblemsCount = 1;
        private const int ExcellentGradeProblemsCount = 2;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {            
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                if (this.problemsSolved < MinProblemsSolved)
                {
                    return MinProblemsSolved;
                }
                else if (this.problemsSolved > MaxProblemsSolved)
                {
                    return MaxProblemsSolved;
                }
                else
                {
                    return this.problemsSolved;
                }                        
            }

            set
            {               
                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            var gradeComment = string.Empty;

            switch (this.ProblemsSolved)
            {
                case BadGradeProblemsCount:
                    gradeComment = "Bad result: nothing done.";
                    break;             
                case AverageGradeProblemsCount:
                    gradeComment = "Average result: almost everything done.";
                    break;
                case ExcellentGradeProblemsCount:
                    gradeComment = "Excellent result: everything is done.";
                    break;
                default:
                    gradeComment = "Invalid number of problems solved!";
                    break;
            }

            return new ExamResult(this.ProblemsSolved, MinProblemsSolved, MaxProblemsSolved, gradeComment);
        }
    }
}
