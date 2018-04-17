using Xunit;
using ClosestString;
using System.Collections.Generic;

namespace ClosestString.UnitTests {

    public class ClosestStringTest {
        private ClosestStrCalcer _closestStrCalcer;

        public ClosestStringTest() {
            _closestStrCalcer = new ClosestStrCalcer();
        }

        [Fact]
        public void testCalcHamming() {
            int actualResult = _closestStrCalcer.calcHamming("ACT", "ACA");
            int expectResult = 1;

            Assert.Equal(expectResult, actualResult);
        }

        [Fact]
        public void testCalcHammingWithUnevenStr() {
            int actualResult = _closestStrCalcer.calcHamming("ACT", "ACAT");
            int expectResult = int.MaxValue;

            Assert.Equal(expectResult, actualResult);
        }

        [Fact]
        public void testDetermineClosestString() {
            List<string> theStrings = new List<string>();
            theStrings.Add("CTCCATCACAC");
            theStrings.Add("AATATCTACAT");
            theStrings.Add("AATATCTACAT");
            theStrings.Add("AATATCTACAT");
            string expectedResult = "AATATCTACAT";
            string actualResult = _closestStrCalcer.determineClosestString(theStrings);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testDetermineClosestStringChallOne() {
            List<string> theStrings = new List<string>();
            theStrings.Add("AACACCCTATA");
            theStrings.Add("CTTCATCCACA");
            theStrings.Add("TTTCAATTTTC");
            theStrings.Add("ACAATCAAACC");
            theStrings.Add("ATTCTACAACT");
            theStrings.Add("ATTCCTTATTC");
            theStrings.Add("ACTTCTCTATT");
            theStrings.Add("TAAAACTCACC");
            theStrings.Add("CTTTTCCCACC");
            theStrings.Add("ACCTTTTCTCA");
            theStrings.Add("TACCACTACTT");

            string expectedResult = "ATTCTACAACT";
            string actualResult = _closestStrCalcer.determineClosestString(theStrings);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testDetermineClosestStringChallTwo() {
            List<string> theStrings = new List<string>();
            theStrings.Add("ACAAAATCCTATCAAAAACTACCATACCAAT");
            theStrings.Add("ACTATACTTCTAATATCATTCATTACACTTT");
            theStrings.Add("TTAACTCCCATTATATATTATTAATTTACCC");
            theStrings.Add("CCAACATACTAAACTTATTTTTTAACTACCA");
            theStrings.Add("TTCTAAACATTACTCCTACACCTACATACCT");
            theStrings.Add("ATCATCAATTACCTAATAATTCCCAATTTAT");
            theStrings.Add("TCCCTAATCATACCATTTTACACTCAAAAAC");
            theStrings.Add("AATTCAAACTTTACACACCCCTCTCATCATC");
            theStrings.Add("CTCCATCTTATCATATAATAAACCAAATTTA");
            theStrings.Add("AAAAATCCATCATTTTTTAATTCCATTCCTT");
            theStrings.Add("CCACTCCAAACACAAAATTATTACAATAACA");
            theStrings.Add("ATATTTACTCACACAAACAATTACCATCACA");
            theStrings.Add("TTCAAATACAAATCTCAAAATCACCTTATTT");
            theStrings.Add("TCCTTTAACAACTTCCCTTATCTATCTATTC");
            theStrings.Add("CATCCATCCCAAAACTCTCACACATAACAAC");
            theStrings.Add("ATTACTTATACAAAATAACTACTCCCCAATA");
            theStrings.Add("TATATTTTAACCACTTACCAAAATCTCTACT");
            theStrings.Add("TCTTTTATATCCATAAATCCAACAACTCCTA");
            theStrings.Add("CTCTCAAACATATATTTCTATAACTCTTATC");
            theStrings.Add("ACAAATAATAAAACATCCATTTCATTCATAA");
            theStrings.Add("CACCACCAAACCTTATAATCCCCAACCACAC");

            string expectedResult = "TTAACTCCCATTATATATTATTAATTTACCC";
            string actualResult = _closestStrCalcer.determineClosestString(theStrings);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}