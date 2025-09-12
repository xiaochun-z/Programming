namespace Programming.Patterns.MergeIntervals.InsertInterval;

/*
Insert Interval (medium)

Problem Statement

Given a list of non-overlapping intervals sorted by their start time, insert a given interval at the correct position and merge all necessary intervals to produce a list that has only mutually exclusive intervals.

Example 1:

Input: Intervals=[[1,3], [5,7], [8,12]], New Interval=[4,6]
Output: [[1,3], [4,7], [8,12]]
Explanation: After insertion, since [4,6] overlaps with [5,7], we merged them into one [4,7].

Example 2:

Input: Intervals=[[1,3], [5,7], [8,12]], New Interval=[4,10]
Output: [[1,3], [4,12]]
Explanation: After insertion, since [4,10] overlaps with [5,7] & [8,12], we merged them into [4,12].

Example 3:

Input: Intervals=[[2,3],[5,7]], New Interval=[1,4]
Output: [[1,4], [5,7]]
Explanation: After insertion, since [1,4] overlaps with [2,3], we merged them into one [1,4].

Constraints:

    1 <= intervals.length <= 104
    intervals[i].length == 2
    0 <= starti <= endi <= 105
    intervals is sorted by starti in ascending order.
    newInterval.length == 2
    0 <= start <= end <= 105
*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Interval
{
    public int Start;
    public int End;

    public Interval(int start, int end)
    {
        this.Start = start;
        this.End = end;
    }
}

public class Solution
{

    public List<Interval> insert(List<Interval> intervals, Interval newInterval)
    {
        List<Interval> mergedIntervals = new List<Interval>();
        var i = 0;
        while (i < intervals.Count && newInterval.Start > intervals[i].End)
        {
            mergedIntervals.Add(intervals[i]);
            i++;
        }

        var current = newInterval;
        while (i < intervals.Count && intervals[i].Start <= newInterval.End)
        {
            current.Start = Math.Min(current.Start, intervals[i].Start);
            current.End = Math.Max(current.End, intervals[i].End);
            i++;
        }

        mergedIntervals.Add(current);

        while (i < intervals.Count)
        {
            mergedIntervals.Add(intervals[i]);
            i++;
        }

        return mergedIntervals;
    }
}
