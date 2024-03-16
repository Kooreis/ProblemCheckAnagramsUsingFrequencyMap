Here is a TypeScript solution for the problem:

```typescript
class AnagramChecker {
    private static createFrequencyMap(str: string): Map<string, number> {
        const frequencyMap = new Map<string, number>();
        for (const char of str) {
            const count = frequencyMap.get(char) || 0;
            frequencyMap.set(char, count + 1);
        }
        return frequencyMap;
    }

    public static areAnagrams(str1: string, str2: string): boolean {
        const frequencyMap1 = this.createFrequencyMap(str1);
        const frequencyMap2 = this.createFrequencyMap(str2);

        if (frequencyMap1.size !== frequencyMap2.size) {
            return false;
        }

        for (const [char, count] of frequencyMap1) {
            if (count !== frequencyMap2.get(char)) {
                return false;
            }
        }

        return true;
    }
}

console.log(AnagramChecker.areAnagrams('listen', 'silent')); // true
console.log(AnagramChecker.areAnagrams('hello', 'world')); // false
```

This console application defines a class `AnagramChecker` with two static methods. The `createFrequencyMap` method creates a frequency map for a given string. The `areAnagrams` method checks if two strings are anagrams by comparing their frequency maps. The application then tests these methods with a couple of example strings.