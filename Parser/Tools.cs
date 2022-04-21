using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stellaris
{
    public static class Tools
    {
        public static string Clean(string dirty) =>
            dirty
                .Replace("\n", "")
                .Replace("\"", "")
                .Replace("\t", "");
    }
}
