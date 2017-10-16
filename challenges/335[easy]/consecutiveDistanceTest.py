import unittest
import consecutiveDistance as cs

class consecutiveDistanceTest(unittest.TestCase):
    
    def testExampleInput1(self):
        listInput = [6, 11]
        expectedOutput = 0
        actualOutput = cs.calcuateConsecutiveDist(listInput)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExampleInput2(self):
        listInput = [31,63,53,56,96,62,73,25,54,55,64]
        expectedOutput = 26
        actualOutput = cs.calcuateConsecutiveDist(listInput)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExampleInput3(self):
        listInput = [77, 39, 35, 38, 41, 42, 76, 73, 40, 31, 10]
        expectedOutput = 20
        actualOutput = cs.calcuateConsecutiveDist(listInput)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExampleInput4(self):
        listInput = [30, 63, 57, 87, 37, 31, 58, 83, 34, 76, 38]
        expectedOutput = 15
        actualOutput = cs.calcuateConsecutiveDist(listInput)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExampleInput5(self):
        listInput = [18, 62, 55, 92, 88, 57, 90, 10, 11, 96, 12]
        expectedOutput = 3
        actualOutput = cs.calcuateConsecutiveDist(listInput)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExampleInput6(self):
        listInput = [26, 8, 7, 25, 52, 17, 45, 64, 11, 35, 12]
        expectedOutput = 6
        actualOutput = cs.calcuateConsecutiveDist(listInput)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExampleInput6(self):
        listInput = [89, 57, 21, 55, 56, 81, 54, 100, 22, 62, 50]
        expectedOutput = 13
        actualOutput = cs.calcuateConsecutiveDist(listInput)
        
        self.assertEqual(expectedOutput, actualOutput)
if __name__ == '__main__':
    unittest.main()