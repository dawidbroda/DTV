using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTV_App.Models.DbModels
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options ) : base(options)
        {

        }

        DbSet<Admins> Admins { get; set; }
        DbSet<Video> Video { get; set; }
    }
}
