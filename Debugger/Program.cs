using Kamael.Packets.Character;
using Kamael.Packets.Clan;
using Kamael.Packets.Status;
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

            if(e.Packet is PacketStatusMovement)
            {
                PacketStatusMovement pkt = (PacketStatusMovement)e.Packet;
                Console.WriteLine($"Move status: Player ID = {pkt.playerId}, " +
                                    $"movetype = {pkt.playerMoveType}, " +
                                    $"destX = {pkt.playerDestXpos}, " +
                                    $"destY = {pkt.playerDestYpos} ");
            }

            if (e.Packet is PacketExpDisplayNotify)
            {
                PacketExpDisplayNotify pkt = (PacketExpDisplayNotify)e.Packet;
                Console.WriteLine($"Exp tick: Exp = {pkt.Exp}, " +
                                    $"Bonus = {pkt.Bonus} ");


            }
            if (e.Packet is PacketClanInfoReadResult)
            {
                PacketClanInfoReadResult pkt = (PacketClanInfoReadResult)e.Packet;
                Console.WriteLine($"Exp tick: Exp = {pkt.CombatPower}, " +
                                    $"Bonus = {pkt.CombatPower2} ");


            }

        }


    }
}

