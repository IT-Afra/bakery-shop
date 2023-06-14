using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Framework
{
    public static class Parser
    {
        public static long ToDateTimeLong(this string value)
        {
            value = value.Replace("/", "");
            value = value.Replace(":", "");
            value = value.Replace("-", "");
            value = value.Replace(" ", "");
            long result;
            if(long.TryParse(value, out result))
                return result;
            return 0;   
        }
    }
}
