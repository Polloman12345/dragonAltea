using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacionDragon.domain
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
