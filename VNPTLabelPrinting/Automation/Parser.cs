using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation {
    public class Parser {

        public static bool isMatchingUidAndSerialOneHome(string uid, string serial) {
            try {
                if (uid.Length != 16) return false;
                if (serial.Length != 15) return false;
                bool r = uid.Substring(uid.Length - 6, 6).Equals(serial.Substring(serial.Length - 6, 6));
                return r;
            } catch { return false; }
        }

        public static bool isMatchingMacAndSerialOneHome(string mac, string serial) {
            try {
                if (mac.Length != 12) return false;
                if (serial.Length != 15) return false;
                bool r = mac.Substring(mac.Length - 6, 6).Equals(serial.Substring(serial.Length - 6, 6));
                return r;
            }
            catch { return false; }
        }

    }
}
