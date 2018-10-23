using Kamael;
using Kamael.Packets;
using Kamael.Packets.Character;
using Kamael.Packets.Clan;
using PacketDotNet;
using SharpPcap;
using System;
using System.Threading.Tasks;

namespace Kamael.Packets
{
    class Debugger
    {
        static void Main(string[] args)
        {
            Globals.args = args;
            Globals.deviceInterface = 0;

            L2RPacketService.Start(ConfigureDevice());

        }


        private static ICaptureDevice ConfigureDevice()
        {
            /* Retrieve the device list  part of initialization*/
            CaptureDeviceList devices = CaptureDeviceList.Instance;
            var iface = L2RPacketService.Initialization(Globals.args);
            ICaptureDevice device = CaptureDeviceList.Instance[Globals.deviceInterface];
            //Register our handler function to the 'packet arrival' event
            device.OnPacketArrival +=
                new PacketArrivalEventHandler(PacketCapturer);
            return device;
        }


        public static async void PacketCapturer(object sender, CaptureEventArgs e)
        {
            DateTime time = e.Packet.Timeval.Date;
            int len = e.Packet.Data.Length;
            IL2RPacket l2rPacket = null;

            Packet packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

            TcpPacket tcpPacket = (PacketDotNet.TcpPacket)packet.Extract(typeof(PacketDotNet.TcpPacket));
            if (tcpPacket != null)
            {
                IPPacket ipPacket = (IPPacket)tcpPacket.ParentPacket;
                System.Net.IPAddress srcIp = ipPacket.SourceAddress;
                System.Net.IPAddress dstIp = ipPacket.DestinationAddress;
                int srcPort = tcpPacket.SourcePort;
                int dstPort = tcpPacket.DestinationPort;
                byte[] payloadData = tcpPacket.PayloadData;

                Console.WriteLine("{0}:{1}:{2}.{3}\tLen={4}\t{5}:{6} -> {7}:{8}",
                time.Hour, time.Minute, time.Second, time.Millisecond, len,
                srcIp, srcPort, dstIp, dstPort);

                // Decrypt and process incoming packets
                if (srcPort == 12000)
                {
                    l2rPacket = L2RPacketService.GetPacket(payloadData);

                    if (l2rPacket is PacketClanMemberKillNotify || l2rPacket is PacketPlayerKillNotify)
                    {
                        Console.WriteLine("GOT ONE!!!!!");
                        //Task.Run(async () => await NotifyKill((PacketClanMemberKillNotify)l2rPacket));
                    }
                }
            }
        }
    }
}
