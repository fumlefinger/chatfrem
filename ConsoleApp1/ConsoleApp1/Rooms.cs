using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rooms
    {


        List<string> chatLog = new List<string>();
        string roomName;

        public Rooms(string name)
        {

            this.roomName = name;

        }

        public string returnLog(int number)
        {
            return this.chatLog[number];
        }

        public string returnName()
        {
            return this.roomName;
        }

        public void PrintLog()
        {
            Console.Clear();
            for (int i = 0; i < this.chatLog.Count(); i++)
            {
                Console.WriteLine(this.chatLog[i]);
                Console.WriteLine();
            }
        }

        public void SaveLog(string text)
        {
            this.chatLog.Add(text);
        }

    }
}
