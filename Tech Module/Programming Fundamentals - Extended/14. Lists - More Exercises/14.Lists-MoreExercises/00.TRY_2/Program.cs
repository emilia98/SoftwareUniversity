using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.TRY_2
{
    class Program
    {
        static void Main()
        {
            List<decimal> grapes = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            int iterations = grapes.Count - 1;
            int countDecreases = 1;
  

            for (int round = 1; round <= n; round++)
            {

                for (int i = 0; i <= iterations; i++)
                {

                    if(grapes[i] > 0)
                    {
                        grapes[i]++;

                    }

                }
                countDecreases = 1;
                for (int j = 1; j <= iterations - 1; j++)
                {
                    int decreasedValues = 0;

                    if (HasSmallerNeighbours(grapes, j))
                    {
                        
                        if (countDecreases == 1)
                        {
                            if(grapes[j - 1] > 0)
                            {
                                grapes[j - 1] -= 2;
                                decreasedValues++;
                            }
                            else
                            {
                                grapes[j - 1] = 0;
                            }

                            if (grapes[j + 1] > 0)
                            {
                                grapes[j + 1] -= 2;
                                decreasedValues++;
                            }                           
                            else
                            {
                                grapes[j + 1] = 0;
                            }                
                            countDecreases++;
                        }
                        else
                        {
                            if (grapes[j - 1] > 0)
                            {
                                grapes[j - 1] -= 1;
                                decreasedValues++;
                            }
                            else
                            {
                                grapes[j - 1] = 0;
                            }

                            if (grapes[j + 1] > 0)
                            {
                                grapes[j + 1] -= 2;
                                decreasedValues++;
                            }
                            else
                            {
                                grapes[j + 1] = 0;
                            }                            
                        }
                        grapes[j] += decreasedValues;
                    }
                   
                }       
                         
                if(round == n)
                {                   
                    int countGrapesLessThanN = 0;
                    for (int z = 0; z <= iterations; z++)
                    {
                        if (grapes[z] <= n)
                        {
                            grapes[z] = 0;
                            countGrapesLessThanN++;
                        }
                    }

                    int grapesMoreThanN = n - countGrapesLessThanN;
                        
                    if(countGrapesLessThanN >= grapesMoreThanN)
                    {
                         break;
                    }
                    else
                    {
                         round = 0;
                    }
                }

            }
            grapes = RemoveSmallerElements(grapes, n);
            Console.WriteLine(String.Join(" ", grapes));
          
        }

        static bool HasSmallerNeighbours(List<decimal> list, int pos)
        {
            decimal currentElement = list[pos];
            decimal previousElement = list[pos - 1];
            decimal nextElement = list[pos + 1];
          
            if (currentElement > previousElement && currentElement > nextElement)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static List<decimal> RemoveSmallerElements(List<decimal> list, int n)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] <= n)
                {
                    list.RemoveAt(i);
                }
            }          
            return list;
        }
    }
}
