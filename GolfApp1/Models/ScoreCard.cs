using System;
using System.Collections.Generic;
using System.Text;

namespace GolfApp1.Models
{
    public class ScoreCard
    {
        public int id { get; set; }
        public int userID { get; set; }
        public int courseID { get; set; }
        public int[] rawScores { get; set; }
        public int[] handicapScores { get; set; }
        public int[] specialScores { get; set; }

        public ScoreCard()
        {
            this.id = -1;
            this.userID = 0;
            this.courseID = 0;
            this.rawScores = new int[18];
            this.handicapScores = new int[18];
            this.specialScores = new int[18];
        }

        public ScoreCard(int i, int ui, int ci)
        {
            this.id = i;
            this.userID = ui;
            this.courseID = ci;
            this.rawScores = new int[18];
            this.handicapScores = new int[18];
            this.specialScores = new int[18];
        }

        public ScoreCard(int i, int ui, int ci, int[] rs, int[] hs, int[] cs)
        {
            this.id = i;
            this.userID = ui;
            this.courseID = ci;
            this.rawScores = rs;
            this.handicapScores = hs;
            this.specialScores = cs;
        }
        public int calcTotal()
        {
            int sum = 0;
            for (int i = 0; i < rawScores.Length; i++)
            {
                sum += rawScores[i];
                sum -= handicapScores[i];
                sum -= specialScores[i];
            }
            return sum;
        }

        public int[] getTotals()
        {
            int[] ans = new int[18];
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = rawScores[i] - handicapScores[i] - specialScores[i];
            }
            return ans;
        }
    }
}
