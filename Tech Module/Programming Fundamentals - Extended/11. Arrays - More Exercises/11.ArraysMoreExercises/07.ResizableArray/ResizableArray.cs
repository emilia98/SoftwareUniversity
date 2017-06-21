using System;

namespace _07.ResizableArray
{
    class ResizableArray
    {
        static void Main()
        {
            //Here, we have an array with given length of 4 elements
            long?[] array = new long?[4];
            string input = Console.ReadLine();
            string[] command = new string[4];
            //The index = 0, because the index of the first element of array
            //is always 0. We will change the value, depending on elements which array holds
            int index = 0;
            //This is a variable, in which we will store the value of the index
            // we will need to resize the array
            // overflow = index = 3
            // overflow = index = 7
            // overflow = index = 11 etc.
            int overflow = 3;

            while (input != "end")
            {
                command = input.Split(' ');

                if (command[0] == "push")
                {
                    long number = long.Parse(command[1]);
                    //The index at first is 0, so that we should increase it
                    //after we've given a value of the array on the 
                    //current position
                    //=> 1) we give a value to the array element
                    //   2) we increase the index, so that we could be
                    //      ready to push the next element   
                    array[index] = number;
                    index++;
                }
                else if (command[0] == "pop")
                {
                    //If we want to pop the last element, we should decrease the index
                    //by 1, because we've already increased it by one when we pushed the
                    //last element, but we don't have a value on postion "index"
                    // Example:
                    //index = 0
                    // push 1 -> index = 1
                    // push 2 -> index = 2
                    // On position index = 2, we don't have a value;
                    // If we have a command "pop", 
                    // if we don't decrease the index by 1, we will pop an array element
                    // which doesn't have a value
                    // So that, I did this -> Search for the last element, which has a value 
                    // the element on position INDEX - 1;

                    array[index - 1] = null;
                    index--;
                }
                else if (command[0] == "removeAt")
                {
                    int toRemoveIndex = int.Parse(command[1]);
                    //Here, we give the element on this position a "null" value.
                    array[toRemoveIndex] = null;
                    //Here, we have a loop which iterates all elements from given position  (the number
                    //after command "removeAt") to the "index" (excluded)
                    for (int j = toRemoveIndex; j < index; j++)
                    {
                        //Here, we shift the elements from the removed value from right to left
                        array[j] = array[j + 1];
                        array[j + 1] = null;
                    }
                    index--;
                }
                else if (command[0] == "clear")
                {
                    for (int i = 0; i <= index; i++)
                    {
                        array[i] = null;
                    }
                    index = 0;
                }

                if (index == overflow)
                {
                    //Here: 
                    //1) we create a new array, which has the same size as the original array 
                    //and it's temporary -> we don't do any operations with its elements
                    //2) we copy the elements from the original array to the new array
                    //3) We change the "overflow" value with adding 4.
                    //4) We change the size of the original array with the "overflow" value;
                    //5) We copy the whole new array, we've previously saved, in the original array
                    long?[] newArray = new long?[overflow + 1];
                    Array.Copy(array, newArray, overflow + 1);
                    overflow += 4;
                    array = new long?[overflow + 1];
                    Array.Copy(newArray, array, overflow - 3);
                }

                input = Console.ReadLine();
            }

            if (index <= 0)
            {
                Console.Write("empty array");
            }
            else
            {
                for (int i = 0; i <= index; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
