using Crud.Entitities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Crud.Persistence
{
    public class CrudDbContext :DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public CrudDbContext(DbContextOptions<CrudDbContext> options): base(options)
        {

        }
    }
}
