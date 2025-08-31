namespace Programming.Patterns.MergeIntervals.MergeIntervals;

using System;
using System.Collections.Generic;
using System.Linq;

/*
Merge Intervals (medium)
leetcode page: https://leetcode.com/problems/merge-intervals/

Problem Statement

Given a list of intervals, merge all the overlapping intervals to produce a list that has only mutually exclusive intervals.

Example 1:

Intervals: [[1,4], [2,5], [7,9]]
Output: [[1,5], [7,9]]
Explanation: Since the first two intervals [1,4] and [2,5] overlap, we merged them into one [1,5].

Example 2:

Intervals: [[6,7], [2,4], [5,9]]
Output: [[2,4], [5,9]]
Explanation: Since the intervals [6,7] and [5,9] overlap, we merged them into one [5,9].

Example 3:

Intervals: [[1,4], [2,6], [3,5]]
Output: [[1,6]]
Explanation: Since all the given intervals overlap, we merged them into one.

Constraints:

    1 <= intervals.length <= 104
    intervals[i].length == 2
    0 <= starti <= endi <= 104
*/
public class Interval
{
    public int Start { get; set; }
    public int End { get; set; }

    public Interval(int start, int end)
    {
        this.Start = start;
        this.End = end;
    }
}

internal class IntervalComparer : IComparer<Interval>
{
    public int Compare(Interval? x, Interval? y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return 0;
        if (y == null) return 1;
        return x.Start.CompareTo(y.Start);
    }
}

public class Solution
{

    public List<Interval> merge(List<Interval> intervals)
    {
        List<Interval> mergedIntervals = [];
        IntervalComparer comparer = new();
        var keys = intervals.Select(a => a.Start).ToArray();
        var intervalArray = intervals.ToArray();
        Array.Sort(intervalArray, comparer);
        var i = 0;
        Interval current = new(intervalArray[i].Start, intervalArray[i].End);
        for (; i < intervalArray.Length; i++)
        {
            if (i + 1 < intervalArray.Length)
            {
                if (current.End < intervalArray[i + 1].Start)
                {
                    mergedIntervals.Add(current);
                    current = new(intervalArray[i + 1].Start, intervalArray[i + 1].End);
                }
                else if (current.End < intervalArray[i + 1].End)
                {
                    current.End = intervalArray[i + 1].End;
                }
            }
            else
            {
                mergedIntervals.Add(current);
            }
        }

        return mergedIntervals;
    }
}
