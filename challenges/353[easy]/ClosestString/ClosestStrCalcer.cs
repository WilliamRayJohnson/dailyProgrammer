using System;
using System.Collections.Generic;

namespace ClosestString {

    public class ClosestStrCalcer {

        // <summary>
        // Calculates the hamming distance of two strings of equal length.
        // </summary>
        // <param name="strOne">The first string to compare</param>
        // <param name="strTwo">The second string to compare</param>
        // <returns>
        // The number of characters that differ or max int if the strings
        // are of unequal length.
        // </returns>
        public int calcHamming(string strOne, string strTwo) {
            int hamDist = int.MaxValue;
            int strLength;

            if (strOne.Length == strTwo.Length) {
                hamDist = 0;
                strLength = strOne.Length;
                for (int i = 0; i < strLength; i++) {
                    if (strOne[i] != strTwo[i])
                        hamDist++;
                }
            }

            return hamDist;
        }

        // <summary>
        // Determines the string in the collection that has the smallest
        // hamming distance between all strings of the collection
        // </summary>
        public string determineClosestString(List<string> theStrings) {
            int smallestTotalHam = int.MaxValue;
            int currStrTotalHam;
            string closestString = String.Empty;

            foreach (string currStr in theStrings) {
                currStrTotalHam = 0;
                foreach (string compareStr in theStrings) {
                    if (!currStr.Equals(compareStr))
                        currStrTotalHam += calcHamming(currStr, compareStr);
                }

                if (currStrTotalHam < smallestTotalHam) {
                    smallestTotalHam = currStrTotalHam;
                    closestString = currStr;
                }
            }
            return closestString;
        }
    }
}
