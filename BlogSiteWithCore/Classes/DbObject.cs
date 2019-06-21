using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteWithCore.Classes
{
    public abstract class DbObject
    {
        public string Id { get; set; }
        public DateTime LastOperationDate { get; set; }
        [MaxLength(20)]
        public string LastOperationerName { get; set; }
        public DbObject()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
