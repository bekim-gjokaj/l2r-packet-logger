using Kamael.Packets;
using System;
using System.Text;

namespace Kamael.Packets.ExtensionMethods
{
    public static class MyExtensions
    {
        

        /// <summary>
        /// Reads the byte.
        /// </summary>
        /// <returns></returns>
        public static byte ReadByte(this IL2RPacket packet)
        {
            byte value = packet._bytes[packet._index];
            packet._index += 1;
            return value;
        }

        /// <summary>
        /// Reads the bytes.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        public static byte[] ReadBytes(this IL2RPacket packet, int length)
        {
            byte[] value = new byte[length];
            Array.Copy(packet._bytes, packet._index, value, 0, length);
            packet._index += length;
            return value;
        }

        

        /// <summary>
        /// Reads the int16.
        /// </summary>
        /// <returns></returns>
        public static short ReadInt16(this IL2RPacket packet)
        {
            short value = BitConverter.ToInt16(packet._bytes, packet._index);
            packet._index += 2;
            return value;
        }

        /// <summary>
        /// Reads the int32.
        /// </summary>
        /// <returns></returns>
        public static int ReadInt32(this IL2RPacket packet)
        {
            int value = BitConverter.ToInt32(packet._bytes, packet._index);
            packet._index += 4;
            return value;
        }

        /// <summary>
        /// Reads the int64.
        /// </summary>
        /// <returns></returns>
        public static long ReadInt64(this IL2RPacket packet)
        {
            long value = BitConverter.ToInt64(packet._bytes, packet._index);
            packet._index += 8;
            return value;
        }

        /// <summary>
        /// Reads the single.
        /// </summary>
        /// <returns></returns>
        public static float ReadSingle(this IL2RPacket packet)
        {
            float value = BitConverter.ToSingle(packet._bytes, packet._index);
            packet._index += 4;
            return value;
        }

        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public static string ReadString(this IL2RPacket packet)
        {
            ushort len = BitConverter.ToUInt16(packet._bytes, packet._index);
            packet._index += 2;
            int length = len;
            if (length > 0)
            {
                string value = Encoding.UTF8.GetString(packet._bytes, packet._index, length);
                packet._index += length;
                return value;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Reads the u int16.
        /// </summary>
        /// <returns></returns>
        public static ushort ReadUInt16(this IL2RPacket packet)
        {
            ushort value = BitConverter.ToUInt16(packet._bytes, packet._index);
            packet._index += 2;
            return value;
        }

        /// <summary>
        /// Reads the u int32.
        /// </summary>
        /// <returns></returns>
        public static uint ReadUInt32(this IL2RPacket packet)
        {
            uint value = BitConverter.ToUInt32(packet._bytes, packet._index);
            packet._index += 4;
            return value;
        }

        /// <summary>
        /// Reads the u int64.
        /// </summary>
        /// <returns></returns>
        public static ulong ReadUInt64(this IL2RPacket packet)
        {
            ulong value = BitConverter.ToUInt64(packet._bytes, packet._index);
            packet._index += 8;
            return value;
        }
        

        /// <summary>
        /// Skips the specified count.
        /// </summary>
        /// <param name="count">The count.</param>
        public static void Skip(this IL2RPacket packet, int count)
        {
            packet._index += count;
        }
    }
}