using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteWithCore.Classes.Entities
{
    public class Blog:DbObject
    {
        public string Text { get; set; }
    }
}
