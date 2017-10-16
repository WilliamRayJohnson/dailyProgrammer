'''
https://www.reddit.com/r/dailyprogrammer/comments/759fha/20171009_challenge_335_easy_consecutive_distance/
'''

def calcuateConsecutiveNDist(listInput, n):
    consectDistRating = 0
    for item in range(len(listInput)):
        consecutiveValue = listInput[item] + n
        if consecutiveValue in listInput:
            consectDistRating += abs(listInput.index(listInput[item]) - listInput.index(consecutiveValue))
    return consectDistRating