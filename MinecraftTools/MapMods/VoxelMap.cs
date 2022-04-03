using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftTools.MapMods
{
    /// <summary>
    /// Information on map format https://github.com/Gjum/voxelmap-cache/blob/master/voxelmap-cache-format.md
    /// </summary>
    public class VoxelMap : IMapMod
    {
        private string MinecraftFolder { get; set; }

        public VoxelMap(string minecraftFolder)
        {
            this.MinecraftFolder = minecraftFolder;
        }

        public List<string> Worlds
        {
            get
            {
                List<string> worlds = new List<string>();

                var voxelMaps = Path.Combine(MinecraftFolder, "voxelmap\\cache");
                if (!Directory.Exists(voxelMaps))
                {
                    return worlds;
                }

                worlds.AddRange(Directory.GetDirectories(voxelMaps));
                worlds.Sort();
                return worlds;
            }
        }

        public List<Waypoint> ExtractWaypoints(string world)
        {
            var waypoints = new List<Waypoint>();
            return waypoints;
        }

        public void SaveWaypoints(string world, List<Waypoint> waypoints)
        {
            throw new NotImplementedException();
        }
    }
}
