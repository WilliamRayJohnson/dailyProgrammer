'''
https://www.reddit.com/r/dailyprogrammer/comments/759fha/20171009_challenge_335_easy_consecutive_distance/
'''

def calcuateConsecutiveDist(listInput):
    sortedList = list(listInput)
    sortedList.sort()
    consectDistRating = 0
    
    for item in range(len(sortedList) - 1):
        consecutiveValue = sortedList[item] + 1
        if consecutiveValue == sortedList[item + 1]:
            consectDistRating += abs(listInput.index(sortedList[item]) - listInput.index(sortedList[item + 1]))
    
    return consectDistRating