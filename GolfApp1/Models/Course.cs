using System;
using System.Collections.Generic;
using System.Text;

namespace GolfApp1.Models
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public int par { get; set; }
        public int[] pars { get; set; }
        public int[] handicaps { get; set; }

        public Course()
        {
            this.id = -1;
            this.name = "";
            this.par = 0;
            this.pars = new int[18];
            this.handicaps = new int[18];
        }

        public Course(int i, string n)
        {
            this.id = i;
            this.name = n;
            this.par = 0;
            this.pars = new int[18];
            this.handicaps = new int[18];
        }

        public Course(int i, string n, int p)
        {
            this.id = i;
            this.name = n;
            this.par = p;
            this.pars = new int[18];
            this.handicaps = new int[18];
        }

        public Course(int i, string n, int p, int[] ps, int[] hs)
        {
            this.id = i;
            this.name = n;
            this.par = p;
            this.pars = ps;
            this.handicaps = hs;
        }
    }
}
