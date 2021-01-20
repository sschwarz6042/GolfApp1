using System;
using System.Collections.Generic;
using System.Text;

namespace GolfApp1.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public int handicap { get; set; }
        public string password { get; set; }
        public int currentCourseID { get; set; }
        public int currentScoreCardID { get; set; }
        public string loggedIn { get; set; }

        public User()
        {
            this.id = -1;
            this.email = "";
            this.username = "";
            this.handicap = 0;
            this.password = "";
            this.currentCourseID = 0;
            this.currentScoreCardID = 0;
            this.loggedIn = "no";
        }

        public User(int i, string e, string u, int h, string p)
        {
            this.id = i;
            this.email = e;
            this.username = u;
            this.handicap = h;
            this.password = p;
            this.currentCourseID = 0;
            this.currentScoreCardID = 0;
            this.loggedIn = "no";
        }

        public User(int i, string e, string u, int h, string p, int ccid, int cscid)
        {
            this.id = i;
            this.email = e;
            this.username = u;
            this.handicap = h;
            this.password = p;
            this.currentCourseID = ccid;
            this.currentScoreCardID = cscid;
            this.loggedIn = "no";
        }

        public User(int i, string e, string u, int h, string p, int ccid, int cscid, string li)
        {
            this.id = i;
            this.email = e;
            this.username = u;
            this.handicap = h;
            this.password = p;
            this.currentCourseID = ccid;
            this.currentScoreCardID = cscid;
            this.loggedIn = li;
        }
    }
}
