namespace Kamael.Packets.Enum
{
    public class QuestState
    {
        public static string Enum(byte value)
        {
            switch (value)
            {
                case 0: return "Not Taken";
                case 1: return "In Progress";
                case 3: return "Complete";
                default: return "Unknown: " + value;
            }
        }
    }
}