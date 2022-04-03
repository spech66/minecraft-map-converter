using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftTools.MapMods
{
    /// <summary>
    /// Information on map format https://github.com/Gjum/voxelmap-cache/blob/master/voxelmap-cache-format.md
    /// name:name,x:x,z:z,y:y,enabled:boolean,red:r,green:g,blue:b,suffix:suffix,world:world,dimensions:dimension#
    /// (not yet used) Information on cache map format https://github.com/Gjum/voxelmap-cache/blob/master/voxelmap-cache-format.md
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

                var voxelMaps = Path.Combine(MinecraftFolder, "voxelmap");
                if (!Directory.Exists(voxelMaps))
                {
                    return worlds;
                }

                worlds.AddRange(Directory.GetFiles(voxelMaps, "*.points"));
                worlds.Sort();
                return worlds;
            }
        }

        public List<Waypoint> ExtractWaypoints(string world)
        {
            var waypoints = new List<Waypoint>();

            if (!File.Exists(world))
                return waypoints;

            // 0         1   2   3   4               5     6       7      8             9           10
            // name:name,x:x,z:z,y:y,enabled:boolean,red:r,green:g,blue:b,suffix:suffix,world:world,dimensions:dimension#
            var lines = File.ReadAllLines(world);
            foreach (var line in lines)
            {
                if (!line.StartsWith("name:"))
                    continue;

                var segments = line.Split(",");
                waypoints.Add(new Waypoint()
                {
                    Name = segments[0].Split(":")[1],
                    X = int.Parse(segments[1].Split(":")[1]),
                    Z = int.Parse(segments[2].Split(":")[1]),
                    Y = int.Parse(segments[3].Split(":")[1]),
                    Dimension = segments[10].Split(":")[1].Replace("#", ""),
                });
            }

            return waypoints;
        }

        public void SaveWaypoints(string world, List<Waypoint> waypoints)
        {
            throw new NotImplementedException();
        }
    }
}
