using System;
using System.Collections.Generic;

namespace _1.List_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            List<char> charList = new List<char>();

            charList.Add('a');
            charList.Add('z');
            charList.Add('r');

            charList.RemoveAt(0);
            charList.Remove('r');
            charList[0] = 'e';
        }
    }
}
