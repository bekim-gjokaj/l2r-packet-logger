namespace Kamael.Packets.Enum
{
    public class ClanRecordGroupType
    {
        public static string Enum(byte CEValue)
        {
            switch (CEValue)
            {
                case 1:
                    return "Strengthening";

                case 2:
                    return "Donate";

                case 3:
                    return "Activity";

                case 4:
                    return "Prize";

                case 5:
                    return "Diplomacy";

                default:
                    return "Unknown Value";
            }
        }
    }
}