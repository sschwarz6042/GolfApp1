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

        public SessionData()
        {
            this.userID = 0;
            this.scoreCardID = 0;
            this.courseID = 0;
        }
        public SessionData(int uid, int sid, int cid)
        {
            this.userID = uid;
            this.scoreCardID = sid;
            this.courseID = cid;
        }
    }
}
