using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// 

/// This class is for doing the most basic
/// of math. I have included only addition
/// 

public class BasicMath
{
    //the private fields
    private int number1;
    private int number2;

    //the empty default constructor
    public BasicMath()
    {
        number1 = 0;
        number2 = 0;
    }

    //an alternate overloaded constructor
    public BasicMath(int num1, int num2)
    {
        NumberOne = num1;
        NumberTwo = num2;
    }

    //public properties
    public int NumberOne
    {
        get { return number1; }
        set { number1 = value; }
    }

    public int NumberTwo
    {
        get { return number2; }
        set { number2 = value; }
    }

    //addition method
    public int Addition()
    {
        return number1 + number2;
    }

    public int Division()
    {
        return number1 / number2;
    }

    public int Remainder()
    {
        return number1 % number2;
    }
}