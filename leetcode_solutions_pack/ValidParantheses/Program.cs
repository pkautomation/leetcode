// https://leetcode.com/problems/valid-parentheses/

bool IsValid(string s)
{
    Stack<char> stack = new();

    foreach (char currentBracket in s)
    {
        switch (currentBracket)
        {
            case '{':
            case '[':
            case '(':
                stack.Push(currentBracket);
                break;
            case '}':
                if (stack.Count == 0 || stack.Pop() != '{') return false;
                break;
            case ']':
                if (stack.Count == 0 || stack.Pop() != '[') return false;
                break;
            case ')':
                if (stack.Count == 0 || stack.Pop() != '(') return false;
                break;
            default:
                return false; // Invalid character
        }
    }

    return stack.Count == 0;
}