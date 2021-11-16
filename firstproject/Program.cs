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
            //get input from user

            //initialize story
            string madlibsStory =
            $"{theMatrix} is a {system}, {neo}. That {system} is our {enemy}." +
            $"But when you're {inside}, you look around, what do you see?" +
            $"Businessmen, teachers, lawyers, carpenters. The very minds" +
            $"of the people we are trying to {save}. But until we do," +
            $"these people are still a part of that {system} and that makes" +
            $"them our {enemy}. You have to understand, most of these people" +
            $"are not ready to be {unplugged}. And many of them are so inured," +
            $"so hopelessly dependent on the {system}, that they will {fight} to protect it.";

            //print story
            Console.WriteLine(madlibsStory);
        }
    }
}
