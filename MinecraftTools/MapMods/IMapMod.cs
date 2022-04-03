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
        public string[] Worlds { get; }
    }
}
