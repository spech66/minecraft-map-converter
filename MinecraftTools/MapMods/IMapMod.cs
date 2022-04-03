using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftTools.MapMods
{
    public interface IMapMod
    {
        /// <summary>
        /// Get the list of supported worlds
        /// </summary>
        public List<string> Worlds { get; }

        /// <summary>
        /// Extract waypoints from world.
        /// </summary>
        /// <param name="world">The world to extratc data from</param>
        /// <returns>List of waypoitns</returns>
        public List<Waypoint> ExtractWaypoints(string world);

        /// <summary>
        /// Save waypoints to tool specific format.
        /// </summary>
        /// <param name="world"></param>
        /// <param name="waypoints"></param>
        public void SaveWaypoints(string world, List<Waypoint> waypoints);
    }
}
