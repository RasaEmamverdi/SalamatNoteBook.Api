using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalamatNoteBook.Entities.DbSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalamatNoteBook.DataService.Data
{
    public class AppDdbContext: IdentityDbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public AppDdbContext(DbContextOptions<AppDdbContext> options):base(options)
        {

        }
    }
}
