using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChoice46C
{
    public partial class SpecialNames
    {
        public static string mName = "6ams5Y+M6amw";

        public static string EncodeNmae(string name)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(name));
        }

        public static string DecodeName(string name)
        {
            byte[] bytes = Convert.FromBase64String(name);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
