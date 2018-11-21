using System;
using System.IO;

namespace Kamael.Packets.Parser
{
    public class HandlerINT
    {
        private static IL2RPacket result;

        public static void TypePacket(PacketReader packet, ushort packetID)
        {
            /*
             *
             * L2RPacket IDs for version: 1.04.16      2018-05-08
             *
             * Currently all packet parsers have been disabled due
             * to changes. Parsers need to be tested and possibly
             * modified before they will work again.
             *
             */

            Console.Write("PacketID: " + packetID.ToString("X") + "\tLength: " + packet.Remaining);
            //Packet Handler for PacketID
            switch (packetID)
            {
                case 203:       // 0xCC
                    result = new PacketStatusMovement(packet);//"PktPlayerMoveListNotify";
                    break;

                    //default:
                    //    result = "(InvalidPacket)";
                    //    break;
            }

            Directory.CreateDirectory(@"Packets");
            string filename = @"Packets\" + result + "-" + packet.Remaining + ".dat";

            using (FileStream SourceStream = File.Open(filename, FileMode.OpenOrCreate))
            {
                SourceStream.Seek(0, SeekOrigin.End);
                SourceStream.WriteAsync(packet._bytes, 0, packet._bytes.Length);
            }

            //using (FileStream fileStream = new FileStream(@"Packets\" + result + "(" + packet.Remaining + ").dat", FileMode.Append, FileAccess.Write, FileShare.Write))
            //{
            //    // Test may not work at all

            //    packet.SetIndex(0);
            //    byte[] length = BitConverter.GetBytes(packet.Remaining + 5);
            //    byte[] PackID = BitConverter.GetBytes(packetID);
            //    fileStream.WriteByte(length[0]);
            //    fileStream.WriteByte(length[1]);
            //    fileStream.WriteByte(0);
            //    fileStream.WriteByte(PackID[0]);
            //    fileStream.WriteByte(PackID[1]);
            //    // End Test
            //    for (int j = 0; j < packet.Remaining;)
            //    {
            //        fileStream.WriteByte(packet.ReadByte());
            //    }
            //}

            Console.Write("\tPacketType: " + result + "\n");
        }
    }
}