using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Spatial;

namespace Coc.Entities
{
    public class PublicPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DbGeography Position { get; set; }
        public Owner Owner { get; set; }
    }
}
