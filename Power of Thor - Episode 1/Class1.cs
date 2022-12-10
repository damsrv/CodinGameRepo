using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        // VARIABLES
        string output = "";
        int actualTx = initialTx;
        int actualTy = initialTy;

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            ///////////////////////////////////////////////////////
            ///THE CODE I ADDED TO RESOLVE THE PROBLEM ///////////
            /////////////////////////////////////////////////////

            output = ""; // reset output string on every iteration

            if (actualTy < lightY) // if thor is too high (closer to zero) he need to go south
            { 
                output += "S"; // We concatenate S to the output string
                actualTy++; // We update the actual position on Y
            }
            if (actualTy > lightY) // if thor is too low ( further to zero) he need to go north
            {
                output += "N";
                actualTy--;
            }
            if (actualTx < lightX) // if thor is too much on the left ( closer to zero on x ) he need to go east
            {
                output += "E";
                actualTx++;
            }
            if (actualTx > lightX) // if thor is too much on the right ( further to zero on x ) he need to go west
            {
                output += "W";
                actualTx--;
            }

            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(output);
        }
    }
}