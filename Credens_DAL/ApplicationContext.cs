using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Credens.Domain.Entity;

namespace Credens.DAL
{
    internal class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }    
        public DbSet<Branch> Branches { get; set; }
    }
}
