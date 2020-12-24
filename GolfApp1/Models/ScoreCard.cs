using System;
using System.Collections.Generic;
using System.Text;

namespace GolfApp1.Models
{
    public class ScoreCard
    {
        public int id { get; set; }
        public int uid { get; set; }
        public int currentTotal { get; set; }

        public int[] rawScores { get; set; }
        public int[] handicapScores { get; set; }
        public int[] specialScores { get; set; }
        public int[] finalScores { get; set; }

        public ScoreCard() {
            this.id = 0;
            this.uid = 0;
            this.currentTotal = 0;
            this.rawScores = new int[18];
            this.handicapScores = new int[18];
            this.specialScores = new int[18];
            this.finalScores = new int[18];
        }

        public void calcFinals() {
            currentTotal = 0;
            for (int i = 0; i < finalScores.Length; i++) {
                this.finalScores[i] = this.rawScores[i] - this.handicapScores[i] - this.specialScores[i];
                currentTotal += this.finalScores[i];
            }
        }
    }
}
