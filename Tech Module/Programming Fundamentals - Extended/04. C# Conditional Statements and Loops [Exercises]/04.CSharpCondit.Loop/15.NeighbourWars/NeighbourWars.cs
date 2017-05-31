using System;

namespace _15.NeighbourWars
{
    class NeighbourWars
    {
        static void Main()
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthGosho = 100, healthPesho = 100;
            short round = 1;
            string attacker = "", kick = "", attacked = "";

            while(healthGosho > 0 && healthPesho > 0)
            {
                if(round % 2 == 0)
                {
                    attacker = "Gosho";
                    kick = "Thunderous fist";
                    attacked = "Pesho";
                    healthPesho -= damageGosho;

                    if(healthPesho > 0)
                    {
                        Console.WriteLine("{0} used {1} and reduced {2} to {3} health.", attacker, kick, attacked, healthPesho);
                    }
                    else
                    {
                        break;
                    }       
                }
                else
                {
                    attacker = "Pesho";
                    kick = "Roundhouse kick";
                    attacked = "Gosho";
                    healthGosho -= damagePesho;

                    if(healthGosho > 0)
                    {
                        Console.WriteLine("{0} used {1} and reduced {2} to {3} health.", attacker, kick, attacked, healthGosho);
                    }
                    else
                    {
                        break;
                    }
                    
                }

                if (round % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
                round++;                
            }
            Console.WriteLine($"{attacker} won in {round}th round.");
        }
    }
}
