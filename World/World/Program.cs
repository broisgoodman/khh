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
          
            

            for (int i = 0; i < 27; i++)
            {
                Console.WriteLine(list[i] + "는 " + i + "번 째 리스트입니다.");

            }
            Console.WriteLine(list[26]);
            for(int i = 0; i < 27; i++)
            {
                if (list[i] is iSwimmable)
                {
                    Console.WriteLine(list[i] + "는 수영중");
                }

            }



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
   abstract class Fish : Creature, iSwimmable
    {
        

    }

    class Monkey : Mammal
    {

    }
    class Whale : Mammal, iSwimmable
    {

    }
    class Dolphin: Mammal, iSwimmable
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
    class Penguin : Birds, iSwimmable
    {

    }
    class Goldfish : Fish, iSwimmable
    {

    }
    class Eel : Fish, iSwimmable
    {

    }
    interface iSwimmable
    {
       

    }


}

