using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.TRY_2
{
    class Program
    {
        static void Main()
        {

            int[] bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] playerAction = Console.ReadLine().Split(' ').ToArray();

            int bulletsIndex = 0;

            for (int index = 0; index < playerAction.Length; index++)
            {
                string[] currentPlayer = playerAction[index].Split(',').ToArray();
                int positions = int.Parse(currentPlayer[0]);
                string direction = currentPlayer[1];

               // Console.WriteLine(positions);
                /*if (bullets[bulletsIndex] == 1)
                {
                    Console.WriteLine("Game over! Player {0} is dead.", index);
                    return;
                }*/

                if (direction == "Right")
                {
                    
                    while (positions > 0)
                    {
                        bulletsIndex++;
                        if (bulletsIndex > 5)
                        {
                            bulletsIndex = 0;
                        }
                        
                        positions--;
                    }                  
                }
                else if (direction == "Left")
                {
                    
                    while (positions > 0)
                    {
                        bulletsIndex--;
                        if (bulletsIndex < 0)
                        {
                            bulletsIndex = 5;
                        }
                        
                        positions--;
                    }
                }
             //   Console.WriteLine(direction);
               /* if (direction == "Right")
                    {
                        if (bulletsIndex + positions < 6)
                        {
                            bulletsIndex += positions;
                        }
                        else
                        {
                            bulletsIndex = positions % 6;
                        }
                    }
                    else if (direction == "Left")
                    {
                        if (bulletsIndex - positions >= 0)
                        {
                            bulletsIndex -= positions;
                        }
                        else
                        {
                            bulletsIndex = 6 - Math.Abs(bulletsIndex - positions);
                       // Console.WriteLine("asas " + bulletsIndex);
                       // Console.WriteLine("Hello");
                        }
                    }*/
                    /* if (bullets[bulletsIndex] == 1)
                     {
                         Console.WriteLine("Game over! Player {0} is dead.", index);
                         return;
                     }
                     else{
                         if (direction == "Right")
                         {
                             if (bulletsIndex + positions < 6)
                             {
                                 bulletsIndex += positions;
                             }
                             else
                             {
                                 bulletsIndex = positions % 6;
                             }
                         }
                         else if (direction == "Left")
                         {
                             if (bulletsIndex - positions >= 0)
                             {
                                 bulletsIndex -= positions;
                             }
                             else
                             {
                                 bulletsIndex = 6 - Math.Abs(bulletsIndex - positions);
                             }
                         }*/
               

               // Console.WriteLine("Player {0} at position {1}",index, bulletsIndex );
                //Console.WriteLine("Next position = {0}", (++bulletsIndex));
                //Console.WriteLine("Hello");
                if (bullets[bulletsIndex] == 1)
                {
                    Console.WriteLine("Game over! Player {0} is dead.", index);
                    return;
                }
               
                
                   // Console.WriteLine("BulletsIndex At = " + bulletsIndex);
                bulletsIndex++;
                if (bulletsIndex > 5)
                {
                    bulletsIndex = 0;
                }
            }
            Console.WriteLine("Everybody got lucky!");         
        }       
    }
}
