using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// 

/// this class returns a random number
/// between the minimum and maximum values
/// 

public class RandomGenerator
{

    //private variables

    private int maximum = 0;
    private int minimum = 0;
    private Random rand;

    //only one constructor that requires a 
    //minimum and maximum value
    public RandomGenerator(int max, int min)
    {
        //initialize the random number 
        rand = new Random();
        maximum = max;
        minimum = min;
    }

    public int GetNumber()
    {
        //return a new random number
        return rand.Next(minimum, maximum);
    }
}