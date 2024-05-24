// https://www.codewars.com/kata/57356c55867b9b7a60000bd7/train/csharp
using System;

public static class BasicMathematicalOperations
{
    public static double basicOp(char operation, double value1, double value2)
    {
        switch (operation)
        {
            case '+':
                return value1 + value2;
            case '-':
                return value1 - value2;
            case '*':
                return value1 * value2;
            case '/':
                return value1 / value2;
        }
        
        return -1;
    }
}