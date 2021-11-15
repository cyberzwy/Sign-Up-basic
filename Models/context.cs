using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectsign.Models
{
    public class context:DbContext
    {
        public context(DbContextOptions<context> options) : base(options) { }
        public DbSet<signup> signup { get; set; }
    }
}
