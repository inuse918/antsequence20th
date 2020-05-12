using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 20;
            string s = "1";// 1에서 시작
            for(int i = 1; i <= end; i++)
            {
                Console.WriteLine(i + "번 째 수열: " + s); //1, 11, 21
                var temp = ""; // 저장할 공간
                var count = 0;
                char c = s[0];
                for(int j = 0; j < s.Length; j++)
                {
                    if (c == s[j]) count++;
                    else 
                    {
                        temp += "" + c + count;
                        count = 0;
                        c = s[j];
                        count++; //2가 1개
                    }
                    if (j + 1 == s.Length) temp += ""+c + count; //""는 값이 섞이는거... 방지하는 듯
                }
                s = temp; //temp에 있던 것을 s로 옮김
            }
        }// main
    }
}
