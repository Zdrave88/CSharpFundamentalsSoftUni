using System.Runtime.InteropServices;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSongs = int.Parse(Console.ReadLine());

            // creating list of objects from the class
            List<Songs> songsList = new List<Songs>();

            for (int i = 0; i < totalSongs; i++)
            {
                // read input as an array devided by "_"
                string[] dataInput = Console.ReadLine().Split("_");
 
                string type = dataInput[0];
                string name = dataInput[1];
                string duration = dataInput[2];
                
                // create object from the class
                Songs song = new();

                // set element from the array above as a property
                song.TypeList = type;
                song.Name = name;
                song.Duration = duration;

                // add the object in the object list
                songsList.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Songs song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                // go through all objects in the list
                foreach (Songs song in songsList)
                {
                    // check if the property of the object is the one as the one we look 
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
        // create a class "X" with "n" properties 
        class Songs
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Duration { get; set; }
        }
    }
}
