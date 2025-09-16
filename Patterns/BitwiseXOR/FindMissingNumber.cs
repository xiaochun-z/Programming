namespace Programming.Patterns.BitwiseXOR.FindMissingNumber;

/*
Given an array of n-1 integers in the range from 1 to n, find the one number that is missing from the array.
*/
using System;

public class Solution
{
    public int findMissingNumber(int[] arr)
    {
        int n = arr.Length + 1;
        // find sum of all numbers from 1 to n.
        int x1 = 1;
        for (int i = 2; i <= n; i++)
            x1 = x1 ^ i;

        // x2 represents XOR of all values in arr
        int x2 = arr[0];
        for (int i = 1; i < n - 1; i++)
            x2 = x2 ^ arr[i];

        // missing number is the xor of x1 and x2
        return x1 ^ x2;
    }
}

/*
Why XOR Works
The XOR operation has useful properties:

$a ^ a = 0$ (a number XORed with itself is 0).
$a ^ 0 = a$ (a number XORed with 0 is itself).
XOR is associative and commutative.

Suppose $n = 5$ and the array is $[1, 2, 4, 5]$. The missing number is 3.

x1 = 1 ^ 2 ^ 3 ^ 4 ^ 5 (XOR of all numbers from 1 to 5).
x2 = 1 ^ 2 ^ 4 ^ 5 (XOR of array elements).
Compute $x1 ^ x2$:

x1 ^ x2 = (1 ^ 2 ^ 3 ^ 4 ^ 5) ^ (1 ^ 2 ^ 4 ^ 5).
Since $1 ^ 1 = 0$, $2 ^ 2 = 0$, $4 ^ 4 = 0$, and $5 ^ 5 = 0$, these pairs cancel out.
This leaves $3 ^ 0 = 3$, which is the missing number.
*/