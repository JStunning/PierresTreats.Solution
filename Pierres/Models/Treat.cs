using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Pierres.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<TreatFlavor>();
        }

        public int TreatId { get; set; }
        public string TreatName { get; set; }     
        public virtual ApplicationUser User { get; set; }


        public int FlavorId { get; set; }
        public virtual ICollection<TreatFlavor> Flavors { get; set; }
    }
}