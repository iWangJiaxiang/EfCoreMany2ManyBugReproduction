using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreMany2ManyBugReproduction.Entities
{
    public class BookTag
    {
        public int BookAId { get; set; }
        public BookA BookA { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
