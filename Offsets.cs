using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigger_Bot
{
    public struct Offsets
    {
        public static string client = "client.dll+";
        public static string localPlayer = "0xDE7964,"; // 0xDE6964 0xDE7964
        public static string m_iHealth = "0x100";
        public static string m_ArmorValue = "0x117CC";
        public static string m_iCrosshairId = "0x11838"; //0x11838
        public static string m_flFlashDuration = "0x10470"; //0x10470
        public static string dwForceAttack = "0x322AC7C"; //0x3229C7C 0x322AC7C
    }
}
