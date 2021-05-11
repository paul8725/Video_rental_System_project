using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_System_project
{
  public  class Movie
    {

        public int ID;
        public String Title;
        public String Ratting;
        public int Year;
        public int Cost;
        public int Copies;
        public String Genre;


        public Movie(int id, String title,String rtg,int yr,int cst,int cop,String gen)
        {
            this.ID = id;
            this.Title = title;
            this.Ratting = rtg;
            this.Year = yr;
            this.Cost = cst;
            this.Copies = cop;
            this.Genre = gen;
        }

    }
}
