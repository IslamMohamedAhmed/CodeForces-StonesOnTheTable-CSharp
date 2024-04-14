using static System.Console;
using static System.Convert;
using static System.Math;



int n,counter=0;


n = ToInt32(ReadLine());
string str = ReadLine();

for(int i=0;i<str.Length; i++)
{
    if (i != n - 1)
    {
        if (str[i] == str[i + 1])
        {
            counter++;
        }
    }
}


WriteLine(counter);