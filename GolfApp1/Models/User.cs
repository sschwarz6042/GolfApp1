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

        public User() {
            this.id = 0;
            this.email = "";
            this.username = "";
            this.handicap = 0;
            this.password = "";
        }
        public User(int i, string e, string u, int h, string p)
        {
            this.id = i;
            this.email = e;
            this.username = u;
            this.handicap = h;
            this.password = p;
        }
    }
}
