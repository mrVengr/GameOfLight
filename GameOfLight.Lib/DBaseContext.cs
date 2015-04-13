using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GameOfLight.Lib
{
    public class DBaseContext: DbContext
    {
        public DbSet<Level> Levels { get; set; }
        public DbSet<Record> Records { get; set; } 
    }
}
