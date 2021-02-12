﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class TechnicianContext : DbContext
    {
        public TechnicianContext(DbContextOptions<TechnicianContext> options)

            : base(options)
    { }
        public DbSet<Technician> Technicians { get; set; }


    }
}
