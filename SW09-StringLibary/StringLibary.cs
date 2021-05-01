using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW09_StringLibary {
    public static class StringLibary {
        public static bool StartsWithUpper(string s) {
            char c = s[0];
            return Char.IsUpper(c);
        }

        public static bool StartsWithLower(string s) {
            char c = s[0];
            return Char.IsLower(c);
        }

        public static bool HasEmbeddedSpaces(string s) { 
            return false;
        }
    }
}
