namespace Programming.Patterns.Greedy.BoatToSavePeople;

/*
Problem Statement (Boats to Save People)

We are given an array people where each element people[i] represents the weight of the i-th person. There is also a weight limit for each boat. Each boat can carry at most two people at a time, but the combined weight of these two people must not exceed limit. The objective is to determine the minimum number of boats required to carry all the people.
Example

Input: people = [10, 55, 70, 20, 90, 85], limit = 100
Output: 4
Explanation: One way to transport all people using 4 boats is as follows:

    Boat 1: Carry people with weights 10 and 90 (total weight = 100).
    Boat 2: Carry a person with weight 85 (total weight = 85).
    Boat 3: Carry people with weights 20 and 70 (total weight = 90).
    Boat 4: Carry people with weights 55 (total weight = 55).

*/

using System;

public class Solution
{
    public int numRescueBoats(int[] people, int limit)
    {
        int boats = 0;
        Array.Sort(people);

        int left = 0;
        int right = people.Length - 1;

        while (left <= right)
        {
            // If we can fit two people (left < right ensures we have two distinct people)
            if (left < right && people[left] + people[right] <= limit)
            {
                left++; // Include the lightest person
                right--; // Include the heaviest person
            }
            else
            {
                right--; // Only include the heaviest person
            }
            boats++; // One boat is used in either case
        }
        return boats;
    }
}
