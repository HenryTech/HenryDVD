using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HenryDVD.Models
{
    public class Actor
    {
        public int ActorID { get; set; }
        public int MovieID { get; set; }
        public string ActorName { get; set; }

        public virtual Movie Movie { get; set; }
    }
}