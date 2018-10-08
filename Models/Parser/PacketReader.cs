using System;
using System.Text;

/// <summary>
///
/// </summary>
namespace Kamael.Packets
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    /// <seealso cref="Kamael.IPacketReader" />
    public class PacketReader : IL2RPacket, IPacketReader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketReader" /> class.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        public PacketReader(byte[] bytes)
            : this(bytes, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketReader" /> class.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <param name="index">The index.</param>
        private PacketReader(byte[] bytes, int index)
        {
            _bytes = bytes;
            _index = index;
        }

        /// <summary>
        /// The bytes
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public byte[] _bytes { get; set; }

        /// <summary>
        /// The index
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int _index { get; set; }

        /// <summary>
        /// Gets the remaining.
        /// </summary>
        /// <value>
        /// The remaining.
        /// </value>
        public int Remaining => _bytes.Length - _index;

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public PacketReader Clone()
        {
            return new PacketReader(_bytes, _index);
        }

        /// <summary>
        /// Reads the byte.
        /// </summary>
        /// <returns></returns>
        public byte ReadByte()
        {
            byte value = _bytes[_index];
            _index += 1;
            return value;
        }

        /// <summary>
        /// Reads the bytes.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        public byte[] ReadBytes(int length)
        {
            byte[] value = new byte[length];
            Array.Copy(_bytes, _index, value, 0, length);
            _index += length;
            return value;
        }

        // TODO: Consider custom reader extensions for different types instead of embedding interpretation here.
        /// <summary>
        /// Reads the date.
        /// </summary>
        /// <returns></returns>
        public DateTime ReadDate()
        {
            long seconds = ReadInt64();
            if (seconds > 0)
            {
                return new DateTime(1970, 1, 1).AddSeconds(seconds /*- 18000 /*This adjusts timezone to EST. Server time is UTC-2 */);
            }
            else
            {
                return DateTime.MaxValue;
            }
        }

        /// <summary>
        /// Reads the int16.
        /// </summary>
        /// <returns></returns>
        public short ReadInt16()
        {
            short value = BitConverter.ToInt16(_bytes, _index);
            _index += 2;
            return value;
        }

        /// <summary>
        /// Reads the int32.
        /// </summary>
        /// <returns></returns>
        public int ReadInt32()
        {
            int value = BitConverter.ToInt32(_bytes, _index);
            _index += 4;
            return value;
        }

        /// <summary>
        /// Reads the int64.
        /// </summary>
        /// <returns></returns>
        public long ReadInt64()
        {
            long value = BitConverter.ToInt64(_bytes, _index);
            _index += 8;
            return value;
        }

        /// <summary>
        /// Reads the single.
        /// </summary>
        /// <returns></returns>
        public float ReadSingle()
        {
            float value = BitConverter.ToSingle(_bytes, _index);
            _index += 4;
            return value;
        }

        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public string ReadString()
        {
            int length = ReadUInt16();
            if (length > 0)
            {
                string value = Encoding.UTF8.GetString(_bytes, _index, length);
                _index += length;
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
        public ushort ReadUInt16()
        {
            ushort value = BitConverter.ToUInt16(_bytes, _index);
            _index += 2;
            return value;
        }

        /// <summary>
        /// Reads the u int32.
        /// </summary>
        /// <returns></returns>
        public uint ReadUInt32()
        {
            uint value = BitConverter.ToUInt32(_bytes, _index);
            _index += 4;
            return value;
        }

        /// <summary>
        /// Reads the u int64.
        /// </summary>
        /// <returns></returns>
        public ulong ReadUInt64()
        {
            ulong value = BitConverter.ToUInt64(_bytes, _index);
            _index += 8;
            return value;
        }

        /// <summary>
        /// Sets the index.
        /// </summary>
        /// <param name="newindex">The newindex.</param>
        public void SetIndex(int newindex)
        {
            _index = newindex;
        }

        /// <summary>
        /// Skips the specified count.
        /// </summary>
        /// <param name="count">The count.</param>
        public void Skip(int count)
        {
            _index += count;
        }
    }
}