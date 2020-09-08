using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProgram
{
    class MessageService
    {
        public void onvideoencoded(object source,EventArgs args)
        {
            Console.WriteLine(" MessageService: sending a meassage");
        }
    }
}
