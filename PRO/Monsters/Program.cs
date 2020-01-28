using System;

namespace Monsters
{
    public class Program
    {
        public int monsterAmount = 0;

        static void Main(string[] args)
        {
               
            Program program1 = new Program();   
            Monster monster1 = new Monster("Mind Flayer", 250, program1);
            Monster monster2 = new Monster("Demigorgon", 100, program1);
            while(program1.monsterAmount > 0)
            {
            if(monster1.monsterHealth > 0)
            {
                Console.WriteLine(monster1.monsterName + " has " + monster1.monsterHealth + " health");
            }
            else
            {
                Console.WriteLine(monster1.monsterName + " is dead");
            }

            if (monster2.monsterHealth > 0)
            {
            Console.WriteLine(monster2.monsterName + " has " + monster2.monsterHealth + " health");
            }
            else
            {
                Console.WriteLine(monster2.monsterName +  " is dead");
            }
            Console.WriteLine("What monster do you want to attack?");
            string target = Console.ReadLine();

            if(target == monster1.monsterName)
            {
                attack(monster1);
            }
            else if (target == monster2.monsterName)
            {
                attack(monster2);
            }

            void attack(Monster targetMonster)
            {
                Random random = new Random();
                int crit = random.Next(10);
                int randomDamage = random.Next(40, 60);
                if (crit <= 2)
                {
                    randomDamage *= 2;
                    targetMonster.monsterHealth -= randomDamage;
                    Console.WriteLine(targetMonster.monsterHealth);
                }
                else if(targetMonster.monsterHealth > 0)
                {
                    targetMonster.monsterHealth -= randomDamage;
                    Console.WriteLine(targetMonster.monsterHealth);                
                }
                else
                {
                    Console.WriteLine("That monster is dead");
                }

                if(targetMonster.monsterHealth <= 0)
                {
                    targetMonster.die(program1);
                }

                
            }
                if (program1.monsterAmount <= 0)
                {
                    Console.WriteLine("All monsters are dead, you win!");
                    Console.ReadKey(true);
                }
                else
                {
                    continue;
                }
            }
        }

    }
}
