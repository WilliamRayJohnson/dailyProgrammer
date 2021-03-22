require_relative 'necklace'

def bool_to_string bool
  bool ? 'true' : 'false'
end

def run_test (neckOne, neckTwo, expected, testNum)
  testMessage = "%s %s Expected: %s Actual: %s\n"
  puts 'Test %d:' % [testNum]
  isSame = same_necklace(neckOne, neckTwo)
  puts testMessage % [neckOne, neckTwo, bool_to_string(expected), bool_to_string(isSame)]
  return isSame == expected
end

TestMessage = "%s %s Expected: %s Actual: %s\n"

testsPassed = 0
testsTotal = 0

#Test 1 - same value
oneNeck1 = 'necklace'
testsTotal += 1
testsPassed = run_test(oneNeck1, oneNeck1, true, 1) ? testsPassed + 1 : testsPassed

#Test 2
twoNeck1 = 'nicole'
twoNeck2 = 'icolen'
testsTotal += 1
testsPassed = run_test(twoNeck1, twoNeck2, true, 2) ? testsPassed + 1 : testsPassed

#Test 3
threeNeck1 = 'abc'
threeNeck2 = 'abcd'
testsTotal += 1
testsPassed = run_test(threeNeck1, threeNeck2, false, 3) ? testsPassed + 1 : testsPassed

#Test 4
fourneck1 = ''
fourNeck2 = 'a'
testsTotal += 1
testsPassed = run_test(fourneck1, fourNeck2, false, 4) ? testsPassed + 1 : testsPassed

#Test 5
testsTotal += 1
testsPassed = run_test('neck', 'nkec', false, 5) ? testsPassed + 1 : testsPassed

puts 'Tests passed: %d/%d' % [testsPassed, testsTotal]
