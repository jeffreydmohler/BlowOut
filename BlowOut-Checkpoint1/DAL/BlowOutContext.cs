using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BlowOut_Checkpoint1.Models;

namespace BlowOut_Checkpoint1.DAL
{
    public class BlowOutContext : DbContext
    {
        public BlowOutContext() : base("BlowOutContext")
        {

        }

        public DbSet<Instruments> instruments { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}