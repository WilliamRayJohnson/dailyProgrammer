def same_necklace (neckOne, neckTwo)
  areNecklacesSame = false
  oneArr = neckOne.split('')
  twoArr = neckTwo.split('')
  oneLength = oneArr.length
  twoLength = twoArr.length

  if oneArr.length != twoArr.length
    puts 'Different length'
    return false
  end

  if oneArr.length == 0 or twoArr.length == 0
    puts 'Zero length'
    return false
  end

  firstMatchingCharInTwo = twoArr.index(oneArr[0])

  if firstMatchingCharInTwo.nil?
    puts 'No matching character'
    return false
  end

  for i in 0 .. oneLength - 1
    j = (firstMatchingCharInTwo + i) % oneLength
    puts '%s %s' % [oneArr[i], twoArr[j]]
    if oneArr[i] != twoArr[j]
      puts 'Character mismatch'
      return false
    end
  end

  return true
end
