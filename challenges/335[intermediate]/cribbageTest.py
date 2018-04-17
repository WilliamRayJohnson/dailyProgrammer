import unittest
import cribbage as crib

class cribbageTest(unittest.TestCase):
    def testExampleHand1(self):
        hand = ['5D','QS','JC','KH','AC']
        expectedScore = 10
        actualScore = crib.scoreHand(hand)
        
        self.assertEqual(expectedScore, actualScore)
        
    def testExampleHand2(self):
        hand = ['8C','AD','10C','6H','7S']
        expectedScore = 7
        actualScore = crib.scoreHand(hand)
        
        self.assertEqual(expectedScore, actualScore)
        
    def testExampleHand3(self):
        hand = ['AC','6D','5C','10C','8C']
        expectedScore = 4
        actualScore = crib.scoreHand(hand)
        
        self.assertEqual(expectedScore, actualScore)
        
if __name__ == '__main__':
    unittest.main()