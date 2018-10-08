namespace Kamael.Packets.Builder
{
    internal class PacketDirector
    {
        private PacketBuilder builder = new PacketBuilderConcrete();

        public L2RPacket Construct()
        {
            for (int i = 0; i < 5; i++)
            {
                builder.BuildPart();
            }

            return builder.Construct();
        }
    }
}