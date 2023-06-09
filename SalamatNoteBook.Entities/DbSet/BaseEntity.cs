using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalamatNoteBook.Entities.DbSet
{
    public abstract class BaseEntity
    {

        public Guid Id 
        {
            get;set;
        } 
        public int Status { get; set; } = 1;
        public DateTime AddeDate
        {
            get; set;
        } = DateTime.UtcNow;
        public DateTime UpdateDate { get; set; }
    }
}
