using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variable
            string theMatrix, system, neo, enemy, inside, save, fight;
            string[] profession = new string[4], adj = new string[2];

            //get input from user


            //initialize story
            string madlibsStory =
            $"{theMatrix} is a {system}, {neo}. That {system} is our {enemy}." +
            $"But when you're {inside}, you look around, what do you see?" +
            $"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}. The very minds" +
            $"of the people we are trying to {save}. But until we do," +
            $"these people are still a part of that {system} and that makes" +
            $"them our {enemy}. You have to understand, most of these people" +
            $"are not ready to be {unplugged}. And many of them are so {adj[0]}," +
            $"so hopelessly {adj[1]} on the {system}, that they will {fight} to protect it.";

            //print story
            Console.WriteLine(madlibsStory);
        }
    }
}
