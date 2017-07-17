using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.NestDic_Phonebook
{
    class NestDic_Phonebook
    {
        static void Main()
        {
            var phonebook = new Dictionary<string, List<long>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                long number = long.Parse(input[1]);

                if(!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, new List<long>());
                }
                phonebook[name].Add(number);
            }

            foreach(KeyValuePair<string, List<long>> record in phonebook)
            {
                string name = record.Key;
                List<long> numbers = record.Value;

                Console.WriteLine("{0}: {1}", name, String.Join(", ",numbers));
            }
        }
    }
}
/*
    Input:
    6
    Pesho 556656
    Maria 1223456
    Stefan 789420
    Pesho 5934710156
    Maria 25656565656
    Maria 56566565656

    Output: 
    Pesho: 556656, 5934710156
    Maria: 1223456, 25656565656, 56566565656
    Stefan: 789420
  */
