using System;
using System.Collections.Generic;
using System.Text;

namespace GolfApp1.Models
{
    public class SessionData
    {
        public int userID { get; set; }
        public int scoreCardID { get; set; }
        public int courseID { get; set; }
        public List<User> watchingPlayers { get; set; }
        public List<ScoreCard> watchingScoreCards { get; set; }

        public SessionData()
        {
            this.userID = 0;
            this.scoreCardID = 0;
            this.courseID = 0;
            this.watchingPlayers = new List<User>();
            this.watchingScoreCards = new List<ScoreCard>();
        }
        public SessionData(int uid, int sid, int cid)
        {
            this.userID = uid;
            this.scoreCardID = sid;
            this.courseID = cid;
            this.watchingPlayers = new List<User>();
            this.watchingScoreCards = new List<ScoreCard>();
        }
        public SessionData(int uid, int sid, int cid, List<User> users, List<ScoreCard> scores)
        {
            this.userID = uid;
            this.scoreCardID = sid;
            this.courseID = cid;
            this.watchingPlayers = users;
            this.watchingScoreCards = scores;
        }
    }
}
