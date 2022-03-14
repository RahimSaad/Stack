using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack
{
    /*
     * stack is ([first in last out] || [last in first out]) DataStructure
     */ 
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------StaticMemoryStack-------------------");
            StaticMemoryStack<Player> StaticStack = new StaticMemoryStack<Player>(3);

            Player[] players = new Player[4] {
                new Player("player A", 13),
                new Player("player B", 26),
                new Player("player C", 11),
                new Player("player D", 9)
            };
            foreach (Player p in players)
            {
                if (!StaticStack.isFull()){
                    StaticStack.push(p);
                    Console.WriteLine("{0} added sucessfully  ,   capacity = {1}", p.name, StaticStack.Size);
                }
                else { Console.WriteLine("Stack is Full  ,\t\t capacity = {0}", StaticStack.Size); }
            }
            
            while (!StaticStack.isEmpty())
            {
                Player p = StaticStack.pop();
                Console.WriteLine(p.name + " popped sucessfully,   capacity = {0}", StaticStack.Size);
            }
            Console.WriteLine("stack is empty,\t\t\t capacity = {0}", StaticStack.Size);
            

            Console.WriteLine("-----------------DynamicMemoryStack-------------------");
            DynamicMemoryStack<Player> DynamicStack = new DynamicMemoryStack<Player>();
            foreach (Player p in players)
            {
                DynamicStack.push(p);
                Console.WriteLine("{0} added sucessfully  ,   capacity = {1}", p.name, DynamicStack.Capacity);
            }
            
            while (!DynamicStack.isEmpty())
            {
                Player p = DynamicStack.pop();
                Console.WriteLine(p.name + " popped sucessfully ,   capacity = {0}", DynamicStack.Capacity);
            }
            Console.WriteLine("stack is empty,  \t\t capacity = {0}", DynamicStack.Capacity);

        }

    }
}
