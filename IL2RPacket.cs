namespace Kamael.Packets
{
    public interface IL2RPacket
    {
        byte[] _bytes { get; set; }
        int _index { get; set; }

        //IL2RPacket Process(IL2RPacket RawPacket);
    }
}