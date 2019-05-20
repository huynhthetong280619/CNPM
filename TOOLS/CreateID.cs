using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class CreateID
    {
        public string ID(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                Random rd = new Random();
                for (int i = 0; i < 3; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2")+(rd.Next(0,10)-10).ToString());
                }
                return sb.ToString();
            }
        }
    }
}
