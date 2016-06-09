using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class InfiniBackEnd:DbContext
    {
        public InfiniBackEnd() : base("DefaultConnection")
        {

        }

        public DbSet<Collection> Collections { get; set; }
        public DbSet<List> Lists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}