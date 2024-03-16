```cpp
#include <iostream>
#include <string>
#include <unordered_map>

bool areAnagrams(std::string str1, std::string str2) {
    std::unordered_map<char, int> freqMap;

    if (str1.length() != str2.length()) {
        return false;
    }

    for (int i = 0; i < str1.length(); i++) {
        freqMap[str1[i]]++;
        freqMap[str2[i]]--;
    }

    for (auto i : freqMap) {
        if (i.second != 0) {
            return false;
        }
    }

    return true;
}

int main() {
    std::string str1, str2;
    std::cout << "Enter first string: ";
    std::cin >> str1;
    std::cout << "Enter second string: ";
    std::cin >> str2;

    if (areAnagrams(str1, str2)) {
        std::cout << "Strings are anagrams." << std::endl;
    } else {
        std::cout << "Strings are not anagrams." << std::endl;
    }

    return 0;
}
```