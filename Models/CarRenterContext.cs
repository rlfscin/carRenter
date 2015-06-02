﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRenter.Models
{
    public class CarRenterContext : DbContext 
    {
        public CarRenterContext() : base("name=connString")
        {
            Database.SetInitializer<CarRenterContext>(new DropCreateDatabaseIfModelChanges<CarRenterContext>());
        }

        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Agency> Agencies { get; set; }

        public virtual DbSet<Rental> Rentals { get; set; }
    }
}