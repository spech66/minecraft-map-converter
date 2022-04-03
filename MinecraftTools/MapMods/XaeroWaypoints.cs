using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftTools.MapMods
{
    /// <summary>
    /// File format information https://www.planetminecraft.com/blog/how-to-convert-voxelmap-waypoints-to-xaero-s-minimap-waypoints/
    /// waypoint:name:initial:x:y:z:color:disabled:type:set:rotated_teleport:rotation_yaw
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
            if (!Directory.Exists(world))
            {
                throw new DirectoryNotFoundException(world);
            }

            CreateSubFolder(world, "dim%0"); // Overworld
            CreateSubFolder(world, "dim%1"); // End
            CreateSubFolder(world, "dim%-1"); // Nether

            WriteWaypointsToFile(world, waypoints, "dim%0", "overworld");
            WriteWaypointsToFile(world, waypoints, "dim%1", "the_end");
            WriteWaypointsToFile(world, waypoints, "dim%-1", "the_nether");
        }

        private void CreateSubFolder(string world, string subFolder)
        {
            var subPath = Path.Combine(world, subFolder);
            if (Directory.Exists(subPath))
            {
                return;
            }

            Directory.CreateDirectory(subPath);
        }
        private void WriteWaypointsToFile(string world, List<Waypoint> waypoints, string dimensionPath, string dimension)
        {
            var dimWaypoints = waypoints.Where(sel => sel.Dimension == dimension);

            using (StreamWriter file = new StreamWriter(Path.Combine(world, dimensionPath, "waypoints.txt")))
            {
                foreach (var wp in dimWaypoints)
                {
                    // waypoint:name:initials:x:y:z:color:disabled:type:set:rotate_on_tp:tp_yaw:global
                    // waypoint:Woodland:W:-2086:107:-3395:4:false:0:gui.xaero_default:false:0:false
                    file.WriteLine(string.Format("waypoint:{0}:{1}:{2}:{3}:{4}:1:false:0:gui.xaero_default:false:0:false", wp.Name, wp.Name[0], wp.X, wp.Y, wp.Z));
                }
            }
        }
    }
}
