using System;
using System.Collections.Generic;
using System.Text;

namespace GolfApp1.Models
{
    public class SessionData
    {
        public User currentUser { get; set; }
        public ScoreCard currentScoreCard { get; set; }
        public Course currentCourse { get; set; }
        public List<User> watchingUsers { get; set; }
        public List<ScoreCard> watchingScoreCards { get; set; }

        public SessionData()
        {
            this.currentUser = new User();
            this.currentScoreCard = new ScoreCard();
            this.currentCourse = new Course();
            this.watchingUsers = new List<User>();
            this.watchingScoreCards = new List<ScoreCard>();
        }
        public SessionData(User u)
        {
            this.currentUser = u;
            this.currentScoreCard = new ScoreCard();
            this.currentCourse = new Course();
            this.watchingUsers = new List<User>();
            this.watchingScoreCards = new List<ScoreCard>();
        }
        public SessionData(User u, ScoreCard sc)
        {
            this.currentUser = u;
            this.currentScoreCard = sc;
            this.currentCourse = new Course();
            this.watchingUsers = new List<User>();
            this.watchingScoreCards = new List<ScoreCard>();
        }
        public SessionData(User u, ScoreCard sc, Course c)
        {
            this.currentUser = u;
            this.currentScoreCard = sc;
            this.currentCourse = c;
            this.watchingUsers = new List<User>();
            this.watchingScoreCards = new List<ScoreCard>();
        }
        public SessionData(User u, ScoreCard sc, Course c, List<User> us)
        {
            this.currentUser = u;
            this.currentScoreCard = sc;
            this.currentCourse = c;
            this.watchingUsers = us;
            this.watchingScoreCards = new List<ScoreCard>();
        }
        public SessionData(User u, ScoreCard sc, Course c, List<User> us, List<ScoreCard> scs)
        {
            this.currentUser = u;
            this.currentScoreCard = sc;
            this.currentCourse = c;
            this.watchingUsers = us;
            this.watchingScoreCards = scs;
        }
    }
}
