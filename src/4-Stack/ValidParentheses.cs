namespace Algo.Stack
{
    public class ValidParentheses
    {
        public static bool IsValid(string s) {
            Stack<char> usedCharacters = new Stack<char>();
            Dictionary<char, char> parenthesesMapper = new Dictionary<char, char>();
            parenthesesMapper.Add(')','(');
            parenthesesMapper.Add(']','[');
            parenthesesMapper.Add('}','{');

            foreach(var tmpChar in s){
                if(parenthesesMapper.ContainsValue(tmpChar)){
                    usedCharacters.Push(tmpChar);
                }
                else{
                    char peekedChar;
                    if(usedCharacters.TryPeek(out peekedChar) && (peekedChar == parenthesesMapper[tmpChar])){
                        usedCharacters.Pop();
                    }
                    else{
                        return false;
                    }
                }
            }

            return usedCharacters.Count == 0;
        }
    }
}