using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Tool
{
    public class base64
    {
        public void ToBase64()
        {
            byte[] AsBytes = File.ReadAllBytes(@"C:\ncr\file.zip");
            String AsBase64String = Convert.ToBase64String(AsBytes);
            byte[] tempBytes = Encoding.ASCII.GetBytes(AsBase64String);
            File.WriteAllBytes(@"C:\ncr\file.txt", tempBytes);
        }

        public void FromBase64()
        {
            byte[] AsBytes = File.ReadAllBytes(@"C:\file.txt");
            String AsBase64String = Encoding.ASCII.GetString(AsBytes);
            byte[] tempBytes = Convert.FromBase64String(AsBase64String);
            File.WriteAllBytes(@"C:\ncr\file_copy.zip", tempBytes);
        }
    }
}
