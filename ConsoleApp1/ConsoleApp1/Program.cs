using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static int roomId;
        static string userInput;
        static List<Rooms> rooms = new List<Rooms>();
        


        static void Main(string[] args)
        {
            rooms.Add(new Rooms("c-sharp room"));
            rooms.Add(new Rooms("python room"));
            ListRooms();
            JoinRoom();
            

        
           
        }

        static void ListRooms()
        {
            
            for (int i = 0; i < rooms.Count();i++)
            {
                Console.WriteLine("["+i+"] -  "+rooms[i].returnName());

            }
            Console.WriteLine("Please enter the number of the room you would like to enter: ");
            userInput = Console.ReadLine();
        }

        static void JoinRoom()
        {
            for (int i = 0; i < rooms.Count();i++)
            {
                if (int.Parse(userInput) == i)
                {
                    rooms[i].PrintLog();
                    roomId = i;
                    break;

                }
            }
            Chatting(roomId);
        }

        static void Chatting(int roomId)
        {
            while(true)
            {
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    break;
                }
                else if (userInput.ToLower() == "logout")
                {
                    break;
                }
                else
                {
                    rooms[roomId].SaveLog(userInput);
                }
                
            }
        }

    }
}
