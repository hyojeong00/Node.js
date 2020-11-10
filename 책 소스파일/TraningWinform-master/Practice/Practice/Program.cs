using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Mammal
    {
        public virtual void Move()
        {
            Console.WriteLine("이동한다");
        }
    }

    class Lion : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("네 발로 걷는다");
        }
    }

    class Whale:Mammal
    {
        public void Move()
        {
            Console.WriteLine("수영한다");
        }
    }

    class Human : Mammal
    {
        public void Move()
        {
            Console.WriteLine("두발로 걷는다");
        }
    }

    class Program
    {       
        static void Main(string[] args)
        {
            Mammal aMammal = new Mammal();
            aMammal.Move();
            aMammal = new Lion();
            aMammal.Move();
            aMammal = new Human();
            aMammal.Move();
            
        }
    }
}
