// https://leetcode.com/problems/valid-parentheses/

bool IsValid(string s) {
    Stack<char> stack = new();

    foreach (char currentBracket in s)
    {
        if (currentBracket.IsOpeningBracket())
        {
            stack.Push(currentBracket);
        }
        else
        {
            if (stack.Count == 0)
            {
                return false;
            }

            var elem = stack.Peek();

            if (elem.IsMatchClosingBracket(currentBracket))
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
        }
    }

    return stack.Count == 0;
}
    


static class Extensions
{
    public static bool IsMatchClosingBracket(this char openingBracket, char closingBracket)
    {
        if (openingBracket == '{' && closingBracket == '}') return true;
        if (openingBracket == '[' && closingBracket == ']') return true;
        if (openingBracket == '(' && closingBracket == ')') return true;
        return false;
    }

    public static bool IsOpeningBracket(this char bracket)
    {
        return bracket == '{' || bracket == '[' || bracket == '(';
    }
}
