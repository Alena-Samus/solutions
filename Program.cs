// See https://aka.ms/new-console-template for more information

string s = "DCXXI";
string currentTwoCharacters = string.Empty;
int result = 0;
int i = -1;
s = s.ToUpper();


Dictionary<String, int> numbers = new Dictionary<String, int>()
{
    {"I",1},
    {"V",5},
    {"X",10},
    {"L",50},
    {"C",100},
    {"D",500},
    {"M",1000},
    {"IV",4},
    {"IX",9},
    {"XL",40},
    {"XC",90},
    {"CD",400},
    {"CM",900}
};


    do
    {
        i++;
        if (i == s.Length - 1)
    {
        result += numbers.TryGetValue(s[i].ToString(), out result) ? result : 0;
    }
        else if (i < s.Length - 1)
        {
            currentTwoCharacters = s[i].ToString() + s[i + 1].ToString();

            if (numbers.ContainsKey(currentTwoCharacters))
            {
                result += numbers.TryGetValue(currentTwoCharacters, out result) ? result : 0;
            i++;
            continue;

            }
            else
            {
                result += numbers.TryGetValue(s[i].ToString(), out result) ? result : 0;
            }
        }
}
    while (i < s.Length);



Console.Write(result);




