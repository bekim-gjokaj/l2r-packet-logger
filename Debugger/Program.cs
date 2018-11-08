using Kamael.Packets.Character;
using Kamael.Packets.Clan;
using PacketDotNet;
using SharpPcap;
using System;
using System.Threading.Tasks;
using static Kamael.Packets.L2RPacketService;

namespace Kamael.Packets
{
    internal class Debugger
    {
        public static L2RPacketService packetsvc;
        private static void Main(string[] args)
        {
            Globals.args = args;
            Globals.deviceInterface = 0;

            packetsvc = new L2RPacketService(Globals.deviceInterface);
            packetsvc.L2RPacketArrivalEvent += OnL2RPacketArrival;
            packetsvc.StartCapture();

            int counter = 0;

            while (true)
            {
                counter++;
                
            }

        }

        private static async void OnL2RPacketArrival(object sender, L2RPacketArrivalEventArgs e)
        {
            var test = e.Packet;
            if (test != null)
                Console.WriteLine("GOT ONE!!");

            //switch (e.Packet.GetType())
            //{

            //}
        }


    }
}

