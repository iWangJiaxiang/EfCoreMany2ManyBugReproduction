using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreMany2ManyBugReproduction.Entities
{
    public abstract class BookBase
    {
        public int Id { get; set; }

        public List<BookTag> Tags { get; set; }
    }
}
