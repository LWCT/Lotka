using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;
using System.IO;
using Relativeship;
namespace Lotka
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Lokta myLokta = new Lokta(0.1f);
            Animal.Animal animalOne = new Animal.Animal(4000);
            Animal.Animal animalTwo = new Animal.Animal(100);

            Relativeship.Relativeship relativeship = new Prey(animalOne,animalTwo,0.1f,0.002f,0.00002f,0.1f);

            myLokta.AddRelativeship(relativeship);

            FileStream fileStream = new FileStream(@"C:\Users\LWG\Desktop\number.txt", FileMode.Open);
            fileStream.Seek(0, SeekOrigin.Begin);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            while (true)
            {
                myLokta.UpdateCount();

                Console.Write("animalOneCount" + animalOne.Count.ToString());

                Console.Write("animalTwoCount" + animalTwo.Count.ToString());
           
                streamWriter.Write((" animalOneCount " + animalOne.Count.ToString() + " animalTwoCount " + animalTwo.Count.ToString() + "\n"));
            }
        }
    }
}
