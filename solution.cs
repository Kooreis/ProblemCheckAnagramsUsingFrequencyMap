```javascript
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

function buildCharCountMap(string) {
    const charCountMap = {};

    for (let char of string.replace(/\W/g, '').toLowerCase()) {
        charCountMap[char] = charCountMap[char] + 1 || 1;
    }

    return charCountMap;
}

console.log(areAnagrams('listen', 'silent')); // true
console.log(areAnagrams('hello', 'world')); // false
```