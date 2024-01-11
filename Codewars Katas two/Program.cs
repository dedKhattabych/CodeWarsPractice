using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Codewars_Katas_two
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPolindrome(16561);
            Console.ReadLine();
        }

        //public static int palindromechainlength(int n)
        //{
        //    string str = n.tostring();

        //    if (str.length % 2 == 0)
        //    {
        //        stringbuilder pook = new stringbuilder();
        //        stringbuilder kek = new stringbuilder();

        //        for (int i = 0; i < str.length / 2; i++)
        //        {
        //            pook.append(str[i]);
        //        }
        //        for (int j = str.length; j <= str.length / 2; j--)
        //        {
        //            kek.append(str[j]);
        //        }
        //        if (pook == kek)
        //        {
        //            return n;
        //        }
        //    }
        //    if (str.length % 2 != 0)
        //    {
        //        stringbuilder pook = new stringbuilder();
        //        stringbuilder kek = new stringbuilder();

        //        for (int i = 0; i < str.length / 2; i++)
        //        {
        //            pook.append(str[i]);
        //        }
        //        for (int j = str.length; j >= str.length / 2; j--)
        //        {
        //            kek.append(str[j]);
        //        }
        //        if (pook == kek)
        //        {
        //            return n;
        //        }
        //    }
        //    var str1 = str.toarray().reverse().tostring();
        //    int sum = int32.parse(str1 + str);

        //    while (ispolindrome)
        //    {

        //    }
        //    return n;
        //}
        public static bool IsPolindrome(int sum) 
        {
            string str = sum.ToString();

            if (str.Length % 2 == 0)
            {
                StringBuilder pook = new StringBuilder();
                StringBuilder kek = new StringBuilder();

                for (int i = 0; i < str.Length / 2; i++)
                {
                    pook.Append(str[i]);
                }
                for (int j = str.Length; j < str.Length/2; j--)
                {
                    kek.Append(str[j]);
                }
                if (pook == kek) return true;
                
            }
            if (str.Length % 2 != 0)
            {
                StringBuilder pook = new StringBuilder();
                StringBuilder kek = new StringBuilder();

                for (int i = 0; i < str.Length / 2; i++)
                {
                    pook.Append(str[i]);
                }
                for (int j = str.Length-1;         j > str.Length/2; j--)
                {
                    kek.Append(str[j]);
                }
                if (pook == kek) return true;
                
            }
            return true;

        }

        //public static string Automorphic(int n)
        //{
        //   string str = n.ToString();

        //   string str1 = (n*n).ToString();

        //    var corIndex = str1.Length - 1;

        //    for (int i = str.Length-1; i > 0; i--)
        //    {
        //        if (str[i] != str1[corIndex]) return "Not!!";
        //        corIndex--;
        //    }
        //    return "Automorphic";
        //}

        //public static string[] AddLength(string str)
        //{
        //    string[] words = str.Split(' ');

        //    for (int word = 0; word < words.Length; word++)
        //    {
        //        words[word] += " " + words[word].Length;
        //    }
        //    return words;
        //}
        //public static string Longest(string s1, string s2)
        //{ 
        //    var longest = new List<char>();
        //    for (int i = 0; i < s1.Length; i++)
        //    {
        //        if (longest.Contains(s1[i]))
        //        {
        //            continue;
        //        }
        //        longest.Add(s1[i]);
        //    }
        //    for (int i = 0; i < s2.Length; i++)
        //    {
        //        if (longest.Contains(s2[i]))
        //        {
        //            continue;
        //        }
        //        longest.Add(s2[i]);
        //    }
        //    var test1 = longest.ToArray().OrderBy(x=>x).ToArray();
        //    return new string(test1);
        //}

        //public static string ReverseWords(string str) // Чекай нейминг переменный гандон!!!!!!!!!!!1111!!!!1!111
        //{
        //    string[] words = str.Split();

        //    StringBuilder strResult = new StringBuilder();
        //    StringBuilder revChars = new StringBuilder();

        //    for (int word = 0; word < words.Length - 1; word++)
        //    {
        //        for (int letter = words[word].Length - 1; letter >= 0; letter--)
        //        {
        //            revChars.Append(words[word][letter]);
        //        }

        //        strResult.Append(revChars.ToString());
        //        strResult.Append(' ');
        //        revChars.Clear();
        //    }

        //    int lastWordIndex = words.Length - 1;
        //    int lastCharIndex = words[lastWordIndex].ToString().Length - 1;

        //    for (int letter = lastCharIndex; letter >= 0; letter--)
        //    {
        //        revChars.Append(words[lastWordIndex][letter]);
        //    }

        //    strResult.Append(revChars.ToString());

        //    return strResult.ToString();
        //}

        //public static int FindLongest(int[] number)
        //{
        //    var longest = number[0];
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        if (longest.ToString().Length == number[i].ToString().Length)
        //        {
        //            continue;
        //        }
        //        longest = Math.Max(longest, number[i]);
        //    }
        //    return longest;
        //}

        //public static List<int> Solve(List<string> arr)
        //{
        //    var alfEnglish = new Dictionary<char, int>() 
        //    {
        //        {'A',1},
        //        {'B',2},
        //        {'C',3}, 
        //        {'D',4},
        //        {'E',5},
        //        {'F',6},
        //        {'G',7},
        //        {'H',8},
        //        {'I',9},
        //        {'J',10},
        //        {'K',11},
        //        {'L',12},
        //        {'M',13},
        //        {'N',14},
        //        {'O',15},
        //        {'P',16},
        //        {'Q',17},
        //        {'R',18},
        //        {'S',19},
        //        {'T',20},
        //        {'U',21},
        //        {'V',22},
        //        {'W',23},
        //        {'X',24},
        //        {'Y',25},
        //        {'Z',26}
        //    };

        //    int[] result = new int[arr.Count];

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        for (int j = 0; j < arr[i].Length; j++)
        //        {
        //            if (j+1 == alfEnglish[Char.ToUpper(arr[i][j])])
        //            {
        //                result[i] += 1;
        //            }
        //        }
        //    }
        //    return result.ToList();
        //}

        //public static double Heron(double a, double b, double c)
        //{
        //    double s = (a + b + c) / 2;

        //    return Math.Sqrt((s * (s - a) * (s - b) * (s - c)));
        //}

        //public static int[] Divisors(int n)
        // {
        //    List<int> divisorCounts = new List<int>();

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (n % i == 0 && i != 1)
        //        {
        //            divisorCounts.Add(i);
        //        }
        //    }
        //    return divisorCounts.Count() == 0 ? null: divisorCounts.ToArray();
        //}

        //public static string HighAndLow(string numbers)
        //{
        //   var str1 = numbers.Split();
        //    List<int> list = new List<int>();

        //    int min = Int32.Parse(str1[0]);
        //    int max = Int32.Parse(str1[0]);

        //    for (int i = 0; i < str1.Length; i++)
        //    {
        //        list.Add(int.Parse(str1[i]));
        //        if (list[i] < min){min = list[i];}
        //        if (list[i] > max){max = list[i];}
        //    }

        //    return $"{max} {min}";
        //}

        //public static int[] BubbleSortOnce(int[] input)
        //{
        //    int[] inputModify = new int[input.Length];
        //    input.CopyTo(inputModify, 0);
        //    int buffer = 0;

        //    for (int i = 0; i < inputModify.Length - 1; i++)
        //    {
        //        if (inputModify[i] > inputModify[i + 1])
        //        {
        //            buffer = inputModify[i];
        //            inputModify[i] = inputModify[i + 1];
        //            inputModify[i + 1] = buffer;
        //        }

        //    }
        //    return inputModify;
        //}
        //public static int[] BubbleSortOnce(int[] UnsortedNumbers)
        //{
        //    var result = (int[])UnsortedNumbers.Clone();
        //    for (var index = 1; index < result.Length; index++)
        //        if (result[index - 1] > result[index])
        //        {
        //            (result[index - 1], result[index]) = (result[index], result[index - 1]);
        //        }

        //    return result;
        //}
    }
}

















