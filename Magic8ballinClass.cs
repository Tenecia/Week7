using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRandom8BallExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter a question for Magic 8 Ball");
            string userReply = Console.ReadLine();
            Random rnd = new Random(); // instanciating a new object
            string[] m8 = { "Outlook good", "without a doubt","yes","no","Dont count on it", "Really hazy, try again", "Things looking good","blue skys" };
            int m8index = rnd.Next(0, m8.Length); // rnd.Next what randomizes our string , "0" first position in index, ".length" goes through entire lenght of array
            Console.WriteLine(m8[m8index]);//tell to pring our string of words randomized.
            Console.ReadLine();
        }
        
    }
}
