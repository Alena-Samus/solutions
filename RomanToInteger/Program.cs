// See https://aka.ms/new-console-template for more information

string[] strs = { "reflower", "flow", "flight" };
string result = "";
string currentChars = string.Empty;
int i = 1;
string[] newStrs = strs.OrderBy(x => x.Length).ToArray();


foreach(char c in newStrs[0])
{
    currentChars += c;

    bool t = strs.All(s => s.StartsWith(currentChars));
    if (t) 
    { 
        result = currentChars; 
    }
    else 
    { 

            break;

    }
 

}



Console.WriteLine (result);




