using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.TRY_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            int iterations = grapes.Count - 1;
            // List<int> indexOfElementsDecreased = new List<int>();
            int countDecreases = 1;

            for (int day = 1; day <= n; day++)
            {
                for (int i = 0; i <= iterations; i++)
                {
                    if (grapes[i] > 0)
                    {
                        grapes[i]++;
                    }

                }

                //indexOfElementsDecreased = new List<int>();
                countDecreases = 1;
                for (int j = 1; j <= iterations - 1; j++)
                {
                    // int decreasedValues = 0;
                    //Console.WriteLine(j + " => " + HasSmallerNeighbours(grapes, j));
                    if (HasSmallerNeighbours(grapes, j))
                    {
                        // Console.WriteLine("j = " + j);
                        //grapes[j] += 2;

                        int before;
                        int after;

                        int decreasedValues = 0;
                        //decreasedBy = grapes[j - 1] + grapes[j + 1];
                        //Console.WriteLine("BEFORE: " + decreasedBy);
                        if (countDecreases == 1)
                        {
                            if (grapes[j - 1] > 0)
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

                            //decreasedBy = grapes[j - 1] + grapes[j + 1];
                            /*
                              before = grapes[j - 1];
                              Console.Write(before + " ");
                              grapes[j - 1] = grapes[j - 1] > 0 ? grapes[j - 1] -= 2 : grapes[j - 1] = 0;

                              after = grapes[j - 1];
                              Console.Write(after + " ");

                              decreasedValues = HasTheCurrentValueChanged(before, after) ? 
                                                  decreasedValues+=1: decreasedValues;
                              Console.WriteLine(decreasedValues);

                              before = grapes[j + 1];
                              Console.Write(before + " ");
                              grapes[j + 1] = grapes[j + 1] > 0 ? grapes[j + 1] -= 2 : grapes[j + 1] = 0;
                              after = grapes[j + 1];
                              Console.Write(after + " ");
                              decreasedValues = HasTheCurrentValueChanged(before, after) ?
                                                 decreasedValues+=1 : decreasedValues;
                              Console.WriteLine(decreasedValues);
                              //decreasedBy = grapes[j - 1] + grapes[j + 1];
                              //indexOfElementsDecreased.Add(j - 1);
                              //indexOfElementsDecreased.Add(j + 1);*/
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
                            /*before = grapes[j - 1];
                            Console.Write(before + " ");
                            grapes[j - 1] = grapes[j - 1] > 0 ? grapes[j - 1] -= 1 : grapes[j - 1] = 0;
                            after = grapes[j - 1];
                            Console.Write(after + " ");
                            decreasedValues = HasTheCurrentValueChanged(before, after) ?
                                               decreasedValues+=1 : decreasedValues;
                            Console.WriteLine(decreasedValues);

                            before = grapes[j + 1];
                            Console.Write(before + " ");
                            grapes[j + 1] = grapes[j + 1] > 0 ? grapes[j + 1] -= 2 : grapes[j + 1] = 0;
                            after = grapes[j + 1];
                            Console.Write(after + " ");

                            decreasedValues = HasTheCurrentValueChanged(before, after) ?
                                               decreasedValues+=1 : decreasedValues;
                            Console.WriteLine(decreasedValues);
                            //decreasedBy = grapes[j - 1] + grapes[j + 1];*/
                        }


                        //decreasedBy -= grapes[j - 1] + grapes[j + 1] - 2;
                        // Console.WriteLine("AFTER: " + decreasedBy);
                        //grapes[j] += decreasedValues;
                        grapes[j] += decreasedValues;
                    }

                }
                //Console.WriteLine("Decreased elemets: " + String.Join(" ",indexOfElementsDecreased));
                if (day == n)
                {
                    //Console.WriteLine(String.Join(" ", grapes));
                    int countGrapesLessThanN = 0;
                    for (int z = 0; z <= iterations; z++)
                    {
                        if (grapes[z] <= n)
                        {
                            grapes[z] = 0;
                            countGrapesLessThanN++;
                        }
                    }
                    // Console.WriteLine("Count grapes less than n: " + countGrapesLessThanN);

                    if (countGrapesLessThanN > n - countGrapesLessThanN)
                    {
                        break;
                    }
                    else
                    {
                        day = 0;
                    }
                }

                //Console.WriteLine(String.Join(" ", grapes));
            }
            grapes = RemoveSmallerElements(grapes, n);
            //Console.WriteLine();
            Console.WriteLine(String.Join(" ", grapes));

        }

        static bool HasSmallerNeighbours(List<int> list, int pos)
        {
            int currentElement = list[pos];
            int previousElement = list[pos - 1];
            int nextElement = list[pos + 1];

            if (currentElement > previousElement && currentElement > nextElement)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static List<int> RemoveSmallerElements(List<int> list, int n)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= n)
                {
                    list.RemoveAt(i);
                }
            }
            // Console.WriteLine("List after removal: " + String.Join(" ", list));
            return list;
        }

        static bool HasTheCurrentValueChanged(int before, int after)
        {
            if (before == after)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
