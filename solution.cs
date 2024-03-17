function areAnagrams(stringA, stringB) {
    const charCountMapA = buildCharCountMap(stringA);
    const charCountMapB = buildCharCountMap(stringB);

    for (let char in charCountMapA) {
        if (charCountMapA[char] !== charCountMapB[char]) {
            return false;
        }
    }

    return true;
}