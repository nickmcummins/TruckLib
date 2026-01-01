using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckLib
{
    internal class MinSupportedVersionAttribute : Attribute
    {
        public uint MinVersion { get; init; }

        public MinSupportedVersionAttribute(uint minVersion)
        {
            MinVersion = minVersion;
        }
    }
}
