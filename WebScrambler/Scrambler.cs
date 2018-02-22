using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebScrambler
{
    public class Scrambler
    {
        public string GetContent()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("http://born2code.net");
            string result = MakeFancy(htmlCode);
            return result;
        }

        private string MakeFancy(string text)
        {
            return "Here is you text: " + text;
        }
    }
}
