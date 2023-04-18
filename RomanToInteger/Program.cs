// See https://aka.ms/new-console-template for more information

using System.Collections;

string s = "()[{{]";

char[] chars = s.ToCharArray();
bool answer = false;
Stack<char> stack = new Stack<char>();
Stack<char> stackOne = new Stack<char>();

foreach (char c in chars)
{
    switch (c)
    {
        case '(':
            stack.Push(c);
            break;
        case '[':
            stack.Push(c);
            break;
        case '{':
            stack.Push(c);
            break;
        case '}':
            if (stack.Count > 0 && stack.Peek() == '{')
            {
                stack.Pop();
            }
            else
            {
                stackOne.Push(c);
            }
            break;
        case ']':
            if (stack.Count > 0 && stack.Peek() == '[')
            {
                stack.Pop();
            }
            else
            {
                stackOne.Push(c);
            }
            break;
        case ')':
            if (stack.Count > 0 && stack.Peek() == '(')
            {
                stack.Pop();
            }
            else
            {
                stackOne.Push(c);
            }
            break;
    }
}



    



if (stack.Count == 0 && stackOne.Count == 0)
{
    answer = true;
}



Console.WriteLine (answer);




