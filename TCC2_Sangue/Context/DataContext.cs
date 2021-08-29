using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TCC2_Sangue.Models;

namespace TCC2_Sangue.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }
        public virtual DbSet<Doador> Doadores { get; set; }

        public virtual DbSet<Sangue> Sangues { get; set; }

    }
}