using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProgram
{
    public class MailServies
    {
        public void onvideoencoded(object source, EventArgs args)
        {
            Console.WriteLine(" Mailservice: sendind and email");
        }
    }
}
