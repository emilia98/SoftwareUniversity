using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> splitInput = input.Split(' ').ToList();
            List<decimal> numbers = new List<decimal>();

            //Here, we parse the string-list to int-list
            for (int i = 0; i < splitInput.Count; i++)
            {
                numbers.Add(decimal.Parse(splitInput[i]));
            }

            decimal sum = 0.0m;

            //Here, we've a loop tht iterates from 0 to count of elements of list  - 1;
            //That's because we check if the element on current position equals to
            //the element on the next position (current position + 1)
            //If the loops iterates all elements until it current postion gets ourList.Counts, but not
            //outList.Counts - 1, we'l have an Exception -> "System.ArgumentOutOfRangeException"
            for (int cnt = 0; cnt < numbers.Count - 1; cnt++)
            { 
                //I we had two equal numbers on position [0] -> [1] or [1] -> [2], we've out counter less 
                // than 0.
                //If we have a counter < 0, we won't enter into the body of if statement. So we will continue
                //iterating loop => We'll only increase the value of the counter by 1.
                if (cnt >= 0)
                {
                    /*If we have to equal numbers:
                        1) we should calculate their sum;
                        2) we should give the left element(element with smaller index) the value of 
                           the sum
                        3) we should remove the right element (element with greater index) 
                           => all elements, positioned on right of this element, will shift left;
                        4) we should decrease our counter by 2, because:
                              - If we don't decrease it, we'll continue with the for-loop, where we'll
                                  increase it  by 1 => will continue with 

                   */
                    if (numbers[cnt] == numbers[cnt + 1])
                    {
                        sum = numbers[cnt] * 2;
                        numbers[cnt] = sum;
                        numbers.RemoveAt(cnt + 1);                        
                        //We increase the counter by 2. Why? 
                        //Read the explanation below:
                        cnt -= 2;
                    }
                    
                }                
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}

/*
   -----------------------------------------------------------------------------------------------------------
   IF WE DOESN'T DECREASE THE COUNTER:
   
    Example: We have this list: 5 5 10 5 5

    - If we don't decrease the counter in the nested if, we'll 
      increase its value in the for loop and we'll continue 
      checking numbers with indexes counter += 1.
      
        See what will happen:
        5 5 10 5 5
        counter = 0
        num[0] = num[1] -> YES
        (5 = 5)
        num[0] = sum = 10;
        num[1] = removed;
        counter = 0; -> we don't change it
        -----------------
        10 10 5 5
        counter = 1
        num[1] = num[2] -> NO
        (10 = 5) 
        We don't enter in the nested if.

        OUR ERROR: We should always check leftmost pairs, so we should compare the number with current index firstly with
the left element, then with the right. 
   -----------------------------------------------------------------------------------------------------------

   ***********************************************************************************************************
    IF WE DECRESE THE COUNTER BY 1:

    - If we decrease the counter in the nested if by 1, we'll increase its value in the for loop, 
      so counter - 1 + 1 = counter. In this case, after we've increased the counter in the for loop, 
      we will check the number.

      See what will happen:
        
      8 2 2 4 8 16
      counter = 0
      num[0] = num[1] -> NO
      --------------------
      8 2 2 4 8 16
      counter++ => counter = 1
      num[1] = num[2] -> YES
      counter-- => counter = 0;
      -----------------------
      8 4 4 8 16
      counter++ => counter = 1;
      num[1] = num[2] -> YES
      counter-- => counter = 0;
      -----------------------
      8 8 8 16                     -> THE MISTAKE IS HERE -> WE SHOULD TAKE LEFTMOST PAIR AND THE RESULT
      counter++ => counter = 1;       SHOULD BE 16 8 16
      num[1] = num[2] -> YES
      counter-- => counter = 0;
      -----------------------
      8 16 16
      counter++ => counter = 1;
      num[1] = num[2] -> YES
      counter-- => counter = 0;
      -----------------------
      8 32
      counter++ => counter = 1;
      - Here, we exit from the loop (counter == num.Count)
      for(int counter = 0; counter < num.Count, counter++)

      OUR ERROR: We don't ensure that we'll return and check if the previous and the element before the 
      previous are equal, but we need so.
   ***********************************************************************************************************

   ///////////////////////////////////////////////////////////////////////////////////////////////////////////
     IF WE DECREASE THE COUNTER BY 2:

    - If we decrease the counter in the nested if by 2, we'll ensure that we'll return and check 
      whether the previous and the element before the previous are equal.
      
     --------------------------------
     8 2 2 4 8 16
     counter = 0
     num[0] == num[1] -> NO
     counter = 0;
     -----------------------------
     8 2 2 4 8 16
     counter++ => counter = 1;
     num[1] == num[2] -> YES
     counter -= 2 => counter = -1;
     -----------------------------
     8 4 4 8 16
     counter++ => counter = 0;
     num[0] == num[1] -> NO
     counter = 0
     -----------------------------
     8 4 4 8 16
     counter++ => counter = 1;
     num[1] == num[2] -> YES
     counter = -1
     -----------------------------
     8 8 8 16
     counter++ => counter = 0;
     num[0] == num[1] -> YES
     counter = -2;
     -----------------------------
     16 8 16
     counter++ => counter = -1;
     -----------------------------
     16 8 16
     counter++ => counter = 0;
     -----------------------------
     16 8 16
     counter++ => counter = 1;
     -----------------------------
     16 8 16 -> here, our counter has decreased and we've exited
     from the loop
     counter = 2 equals to num.Count = 2, but we need cunter to be less than
     num.Count
*/
