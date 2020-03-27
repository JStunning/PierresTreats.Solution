using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Pierres.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
        }
        public int FlavorId {get; set;}
        public string FlavorName {get; set;}
        public int TreatId { get; set; }
        public  ICollection<TreatFlavor> Treats { get; }
    }
}