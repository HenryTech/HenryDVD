using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HenryDVD.Models
{
    public class Movie
    {

        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }

    }
}