using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftTools.MapMods
{
    /// <summary>
    /// File format information https://www.planetminecraft.com/blog/how-to-convert-voxelmap-waypoints-to-xaero-s-minimap-waypoints/
    /// </summary>
    public class XaeroWaypoints : IMapMod
    {
        private string MinecraftFolder { get; set; }

        public XaeroWaypoints(string minecraftFolder)
        {
            this.MinecraftFolder = minecraftFolder;
        }

        public List<string> Worlds
        {
            get
            {
                List<string> worlds = new List<string>();

                var xaeroWaypoints = Path.Combine(MinecraftFolder, "XaeroWaypoints");
                if(!Directory.Exists(xaeroWaypoints))
                {
                    return worlds;
                }

                worlds.AddRange(Directory.GetDirectories(xaeroWaypoints));
                worlds.Sort();
                return worlds;
            }
        }

        public List<Waypoint> ExtractWaypoints(string world)
        {
            throw new NotImplementedException();
        }

        public void SaveWaypoints(string world, List<Waypoint> waypoints)
        {
            throw new NotImplementedException();
        }
    }
}
