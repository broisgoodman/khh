using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{

    class Program
    {
        static void Main(string[] args)
        {
            
            //Monkey monkey1 = new Monkey();
            //Monkey monkey2 = new Monkey();
            //Monkey monkey3 = new Monkey();
           // Whale whale1 = new Whale();
           // Whale whale2 = new Whale();
           // Whale whale3 = new Whale();
            //Dolphin dolphin1 = new Dolphin();
          //  Dolphin dolphin2 = new Dolphin();
           // Dolphin dolphin3 = new Dolphin();
           // Eagle eagle1 = new Eagle();
           // Eagle eagle2 = new Eagle();
           // Eagle eagle3 = new Eagle();
           // Sparrow sparrow1 = new Sparrow();
           // Sparrow sparrow2 = new Sparrow();
           // Sparrow sparrow3 = new Sparrow();
           // Pigeon pigeon1 = new Pigeon();
           // Pigeon pigeon2 = new Pigeon();
           // Pigeon pigeon3 = new Pigeon();
            //Penguin penguin1 = new Penguin();
            //Penguin penguin2 = new Penguin();
           // Penguin penguin3 = new Penguin();
           // Goldfish goldfish1 = new Goldfish();
           // Goldfish goldfish2 = new Goldfish();
           // Goldfish goldfish3 = new Goldfish();
           // Eel eel1 = new Eel();
            //Eel eel2 = new Eel();
            //Eel eel3 = new Eel();

            TheWorld theWorld = new TheWorld();
            List<Creature> list = new List<Creature>();
           
            list.Add(new Monkey());
            list.Add(new Monkey());
            list.Add(new Monkey());
            list.Add(new Whale());
            list.Add(new Whale());
            list.Add(new Whale());
            list.Add(new Dolphin());
            list.Add(new Dolphin());
            list.Add(new Dolphin());
            list.Add(new Eagle());
            list.Add(new Eagle());
            list.Add(new Eagle());
            list.Add(new Sparrow());
            list.Add(new Sparrow());
            list.Add(new Sparrow());
            list.Add(new Pigeon());
            list.Add(new Pigeon());
            list.Add(new Pigeon());
            list.Add(new Penguin());
            list.Add(new Penguin());
            list.Add(new Penguin());
            list.Add(new Goldfish());
            list.Add(new Goldfish());
            list.Add(new Goldfish());
            list.Add(new Eel());
            list.Add(new Eel());
            list.Add(new Eel());
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);
            Console.WriteLine(list[4]);
            Console.WriteLine(list[5]);
            Console.WriteLine(list[6]);
            Console.WriteLine(list[7]);
            Console.WriteLine(list[8]);
            Console.WriteLine(list[9]);
            Console.WriteLine(list[10]);
            Console.WriteLine(list[11]);
            Console.WriteLine(list[12]);
            Console.WriteLine(list[13]);
            Console.WriteLine(list[14]);
            Console.WriteLine(list[15]);
            Console.WriteLine(list[16]);
            Console.WriteLine(list[17]);
            Console.WriteLine(list[18]);
            Console.WriteLine(list[19]);
            Console.WriteLine(list[20]);
            Console.WriteLine(list[21]);
            Console.WriteLine(list[22]);
            Console.WriteLine(list[23]);
            Console.WriteLine(list[24]);
            Console.WriteLine(list[25]);
            Console.WriteLine(list[26]);
          

        }






    }


    class TheWorld
    {

    }


    abstract class Creature : TheWorld
    {
        
    }
    abstract class Mammal : Creature
    {

    }

    abstract class Birds : Creature
    {

    }
    abstract class Fish : Creature
    {

    }

    class Monkey : Mammal
    {

    }
    class Whale : Mammal
    {

    }
    class Dolphin: Mammal
    {

    }
    class Eagle : Birds
    {

    }
    class Sparrow : Birds
    {

    }
    class Pigeon : Birds
    {

    }
    class Penguin : Birds
    {

    }
    class Goldfish : Fish
    {

    }
    class Eel : Fish
    {

    }
}

