public class Solution {
    public bool DetectCapitalUse(string word) {
        var len = word.Length;
        if (len <= 1)
            return true;
        var first = isUpper(word[0]);
        var prev = isUpper(word[1]);
        
        for (var i=2; i<len; ++i){
var curr = isUpper(word[i]);
            if (curr != prev)
                return false;
            prev = curr;
}
        return !prev || (first && prev);
    }
    
    public bool isUpper(char ch){
return ch >= 'A' && ch <= 'Z';
}

}