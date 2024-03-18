function buildCharCountMap(string) {
    const charCountMap = {};

    for (let char of string.replace(/\W/g, '').toLowerCase()) {
        charCountMap[char] = charCountMap[char] + 1 || 1;
    }

    return charCountMap;
}