namespace Kamael.Packets.Enum
{
    public class ClanRecordTypeSimple
    {
        public static string Enum(byte CEValue)
        {
            switch (CEValue)
            {
                case 0:
                    return "Adena";

                case 1:
                    return "Proof of Blood";

                case 24:
                    return "Red Starstone";

                default:
                    return "Unknown Value";
            }
        }
    }
}