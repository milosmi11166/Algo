using System.Text;

namespace Algo.TwoPointers;

public class Palindrome {
    public static bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (var character in s)
        {
            if(Char.IsLetter(character))
                sb.Append(Char.ToLower(character));
        }
        var s1 = sb.ToString();

        if(s1.Length == 0){
            return true;
        }
        if(s1.Length == 1){
            return true;
        }
        
        for(int i = 0; i < s1.Length; i++){
            if(s1[i]!=s1[s1.Length-i-1]){
                return false;
            }
        }

        return true;
    }
}