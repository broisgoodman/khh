using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacepractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Character me = new Character();
           
            Character you = new Character();
            
            me.Attack(you);
            you.Attack(me);
            Console.WriteLine($"나의 hp는 {me.hp} 입니다");
            Console.WriteLine($"상대방의 hp는 {you.hp} 입니다");
            me.Attack(you);
            you.Attack(me);
            Console.WriteLine($"나의 hp는 {me.hp} 입니다");
            Console.WriteLine($"상대방의 hp는 {you.hp} 입니다");
        }
        
        }
    }

class Character
{
    public int hp = 100;
    public int dmg = 10;
  public void Attack(Character target)
    {
        target.Damaged(dmg);
    }
  public void Damaged(int damage)
    {
        hp -= damage;
    }
  
    


}
   

