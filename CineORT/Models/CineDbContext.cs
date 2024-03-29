﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CineORT.Models;

namespace CineORT.Models
{
    
    
        public class CineDbContext : DbContext
        {
            public CineDbContext(DbContextOptions opciones) : base(opciones)
            {

            }
            public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Administrador> Administradors { get; set; }

        public DbSet<CineORT.Models.Reserva> Reserva { get; set; }


    }

    }
