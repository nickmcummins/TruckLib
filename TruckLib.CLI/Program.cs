using System;
using TruckLib.HashFs;
using TruckLib.ScsMap;

namespace TruckLib.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mapFilename = args[0];
            IHashFsReader reader = HashFsReader.Open(mapFilename);

            Map map = Map.Open("/map/usa.mbd", reader);
            Console.Out.WriteLine(map);
        }
    }
}
