using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    // There is a collection of rocks where each rock has various
    // minerals embeded in it. Each type of mineral is designated
    // by a lowercase letter in the range ascii[a-z]. There may be
    // multiple occurrences of a mineral in a rock. A mineral is
    // called a gemstone if it occurs at least once in each of the
    // rocks in the collection.

    // Given a list of minerals embedded in each of the rocks,
    // display the number of types of gemstones in the collection.

    // Example
    // arr = ["abc", "abc", "bc"]
    // The minerals b and c appear in each rock, so there are 2 gemstones.

    // Complete the gemstones function below.
    static int gemstones(string[] rocks)
    {
        int[] minerals = new int[26];

        // Loop through the rocks
        for (int idx = 0; idx < rocks.Length; idx++)
        {
            // Mark the ones that are still in the
            // running to be gemstones
            foreach (char mineral in rocks[idx])
            {
                if (minerals[mineral - 'a'] == idx)
                    minerals[mineral - 'a']++;
            }
        }
        
        // The mineral counts will equal rocks.Length if it appeared in every rock
        return minerals.Count(val => val == rocks.Length);
    }

    static void Main(string[] args)
    {
        string[][] testcases = new string[][]
        {
            new string[] { "abcdde", "baccd", "eeabg" },
            new string[] { "basdfj", "asdlkjfdjsa", "bnafvfnsd", "oafhdlasd" },
        };

        foreach(string[] testcase in testcases)
        {
            int result = gemstones(testcase);
            Console.WriteLine(result);
        }
    }
}
