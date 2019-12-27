using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Extension
{
    public static class CommonExtension
    {
        public static bool NotEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }

    }
}
