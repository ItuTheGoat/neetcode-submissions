class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s: string, t: string): boolean {
        if(s.length !== t.length) {
            return false;
        }
        let sArray = s.split("").sort();
        let tArray = t.split("").sort();

        const stringSet = new Set();

        for(let i = 0; i < sArray.length; i++) {
            if(sArray[i] != tArray[i]) {
                return false;
            }
            stringSet.add(sArray[i]);
        }

        return true;
    }
}
