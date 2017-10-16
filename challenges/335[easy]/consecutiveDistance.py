'''
https://www.reddit.com/r/dailyprogrammer/comments/759fha/20171009_challenge_335_easy_consecutive_distance/
'''

def calcuateConsecutiveNDist(listInput, n):
    sortedList = list(listInput)
    sortedList.sort()
    consectDistRating = 0
    
    for item in range(len(sortedList) - 1):
        consecutiveValue = sortedList[item] + n
        if consecutiveValue in sortedList:
            consectDistRating += abs(listInput.index(sortedList[item]) - listInput.index(consecutiveValue))
    
    return consectDistRating