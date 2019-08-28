using System;
using System.Collections.Generic;
using System.Text;

namespace Vietbank.Core.Helper
{
    public class Base64Helper
    {
        public static string Base64Encode(string base64Encoded)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(base64Encoded);
            return Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
