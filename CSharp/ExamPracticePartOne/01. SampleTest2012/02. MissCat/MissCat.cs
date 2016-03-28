using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());        
            CheckJudgeCount(judgesCount);

            var catVotes = GetJudgesVotes(judgesCount);
            int winner = GetWinnerCat(catVotes);
        
            Console.WriteLine(winner);
        }


        static void CheckJudgeCount(int judgesCount)
        {
            if (judgesCount < 1 || judgesCount > 100000)
            {
                return;
            }
        }

        static List<int> GetJudgesVotes(int judgesCount)
        {
            List<int> catVotes = new List<int>();

            for (int i = 1; i <= judgesCount; i++)
            {
                int subjectiveJudgeVote = int.Parse(Console.ReadLine());
                catVotes.Add(subjectiveJudgeVote);               
            }

            return catVotes;
        }

        static int GetWinnerCat(List<int> votes)
        {
            Dictionary<int, int> voteCounts = votes.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            var maxVal = voteCounts.Max(x => x.Value);
            var winnerKey = voteCounts.Where(pair => pair.Value == maxVal)
                                                .Select(pair => pair.Key)
                                                .FirstOrDefault();

            return winnerKey;
        }
    }
}
