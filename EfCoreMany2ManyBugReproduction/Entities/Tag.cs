using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreMany2ManyBugReproduction.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<BookTag> Books { get; set; }
    }
}
