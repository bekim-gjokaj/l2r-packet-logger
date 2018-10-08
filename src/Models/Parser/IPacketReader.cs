using Kamael.Packets;
using System;

namespace Kamael
{
    public interface IPacketReader
    {
        int Remaining { get; }

        PacketReader Clone();

        byte ReadByte();

        byte[] ReadBytes(int length);

        DateTime ReadDate();

        short ReadInt16();

        int ReadInt32();

        long ReadInt64();

        float ReadSingle();

        string ReadString();

        ushort ReadUInt16();

        uint ReadUInt32();

        ulong ReadUInt64();

        void SetIndex(int newindex);

        void Skip(int count);
    }
}