using System;
using System.Collections.Generic;
using System.Text;

namespace LinqHomeWork.Blanks
{
    public class Hdd : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double Price { get; set; }
        public bool IsHit { get; set; }
        public string Creater { get; set; }
        public string Interface { get; set; }
        public int Volume { get; set; }
        public int Buffer { get; set; }
        public int SpindleSpeed { get; set; }
    }
}
