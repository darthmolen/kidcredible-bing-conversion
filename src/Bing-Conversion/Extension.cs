using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bing.Conversion
{
    public static class Extension
    {
        public static string ToCommaDelimited(this List<string> list)
        {
            return String.Join(',', list);
        }
    }
}
