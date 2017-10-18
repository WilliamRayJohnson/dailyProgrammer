import unittest
import cannibalNumbers as cn

class cannibalNumberTest(unittest.TestCase):
    
    def testExample1(self):
        inputList = [21, 9, 5, 8, 10, 1, 3]
        target = 10
        expectedOutput = 4
        actualOutput = cn.countCannibals(target, inputList)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExample2(self):
        inputList = [21, 9, 5, 8, 10, 1, 3]
        target = 15
        expectedOutput = 2
        actualOutput = cn.countCannibals(target, inputList)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExample3(self):
        inputList = [4,4,4,4,4,4,4]
        target = 5
        expectedOutput = 0
        actualOutput = cn.countCannibals(target, inputList)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testExample4(self):
        inputList = [3,3,3,2,2,2,1,1,1]
        target = 4
        expectedOutput = 4
        actualOutput = cn.countCannibals(target, inputList)
        
        self.assertEqual(expectedOutput, actualOutput)
        
    def testQueryCannibalCounts(self):
        inputList = [21, 9, 5, 8, 10, 1, 3]
        queries = [10, 15]
        expectedOutput = [4, 2]
        actualOutput = cn.queryCannibalCount(queries, inputList)
        
        self.assertEqual(expectedOutput, actualOutput)
        
if __name__ == '__main__':
    unittest.main()