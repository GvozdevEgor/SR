using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace InterfaceRS232
{
    public class RS232
    {        
        SerialPort RS = new SerialPort();
        private Queue<string> ReadBuffer = new Queue<string>();
        private Queue<string> WriteBuffer = new Queue<string>();

        public void SendData(string Data) => WriteBuffer.Enqueue(Data);

        public bool GetMessage(out string Data)
        {
            if (ReadBuffer.Count > 0)
            {
                Data = ReadBuffer.Dequeue();
                return true;
            }
            else
            {
                Data = "";
                return false;
            }
        }
    }
}
