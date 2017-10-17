'''
https://www.reddit.com/r/dailyprogrammer/comments/76qk58/20171016_challenge_336_easy_cannibal_numbers/
'''

def countCannibals(targetValue, numberSet):
    numberSet.sort()
    numberSet = numberSet[::-1]
    cannibalCount = 0
    while 0 < len(numberSet):
        if numberSet[0] >= targetValue:
            cannibalCount += 1
            numberSet = numberSet[1:]
        elif len(numberSet) >= 2:
            if numberSet[0] > numberSet[1]:
                numberSet[0] += 1
                numberSet = numberSet[:len(numberSet)-1]
            else:
                numberSet = numberSet[1:]
        else:
            numberSet = numberSet[1:]
    return cannibalCount
    
def queryCannibalCount(queries, numberSet):
    cannibalCounts = []
    for query in queries:
        cannibalCounts.append(countCannibals(query, numberSet))
    return cannibalCounts