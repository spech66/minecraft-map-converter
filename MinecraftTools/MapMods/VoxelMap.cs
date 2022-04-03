using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftTools.MapMods
{
    public class VoxelMap : IMapMod
    {
        private string MinecraftFolder { get; set; }

        public VoxelMap(string minecraftFolder)
        {
            this.MinecraftFolder = minecraftFolder;
        }

        public string[] Worlds
        {
            get
            {
                List<string> worlds = new List<string>();
                worlds.Add("1");
                return worlds.ToArray();
            }
        }
    }
}
