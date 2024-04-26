using System;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            var milk = new Milk("Простоквашино", true, 200);
            var banana = new Banana("Бананы фасованные", true, 550);
            var milkClone = milk.MyClone();
            var bananaClone = banana.MyClone();
            if (milk.Equals(milkClone))
                Console.WriteLine("milk склонирован успешно");
            if (banana.Equals(bananaClone))
                 Console.WriteLine("Banana склонирован успешно");

            Console.ReadLine();


        }
    }
}
