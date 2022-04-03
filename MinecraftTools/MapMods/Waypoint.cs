using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftTools.MapMods
{
    public class Waypoint
    {
        public string Name { get; set; } = "";

        public int X { get; set; } = 0;

        public int Y { get; set; } = 0;

        public int Z { get; set; } = 0;
        
        public string Dimension { get; set; } = "";
    }
}
