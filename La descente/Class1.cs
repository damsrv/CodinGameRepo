using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {
        int[] array = new int[8];

        // game loop
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.

                array[i] = mountainH; // add the value in an array of int
            }


            ///////////////////////////////////////////////////////
            ///THE CODE I ADDED TO RESOLVE THE PROBLEM ///////////
            /////////////////////////////////////////////////////


            int highestMountain = array.Max(); // Get the first occurence of the biggest value in the array

            int highestMountainIndex = Array.IndexOf(array, highestMountain); // Get the index of highestMountain 

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(highestMountainIndex); // The index of the mountain to fire on.

        }
    }
}