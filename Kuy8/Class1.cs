﻿using System;
/*
 Summation
 Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.

 For example:

 summation(2) -> 3
 1 + 2

 summation(8) -> 36
 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8
*/

public static class Kata
{
    public static int summation(int number)
    {
        int result = 0;

        for (var i = 0; i <= number; i++)
        {
            result += i;
        }

        return result;
    }
}

/*
 using System;

 public static class Kata 
 {
     public static int summation(int num)
     {
       return num*(num+1)/2;
     }
 }
*/