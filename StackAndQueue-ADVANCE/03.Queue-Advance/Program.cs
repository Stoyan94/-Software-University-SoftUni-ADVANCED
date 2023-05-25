using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Queue_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs= Console.ReadLine().Split(", ");

            Queue<string> listSongs = new Queue<string>(inputSongs);

            while (listSongs.Count>0)
            {
                string [] commands = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];

                if (command=="Add")
                {
                    
                    AddSong(listSongs,commands);
                }
                else if (command == "Play")
                {
                    listSongs.Dequeue();
                }
                else if (command=="Show")
                {
                    ShowSongs(listSongs);
                }
            }

            Console.WriteLine("No more songs!");
        }

        private static void ShowSongs(Queue<string> listSongs)
        {
            string songs = string.Join(", ", listSongs);
            Console.WriteLine(songs);
        }

        private static void AddSong(Queue<string> listSongs,string [] songName)
        {
            string currSong = string.Join(" ",songName.Skip(1));

            if (!listSongs.Contains(currSong))
            {
                listSongs.Enqueue(currSong);
            }
            else
            {
                Console.WriteLine($"{currSong} is already contained!");
            }
        }
    }
}
