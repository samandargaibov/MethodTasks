using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLessons
{
    internal class StringTasks
    {

        public static string AddString()
        {
            Console.Write("Metni qeyd edin: ");
            string text = Console.ReadLine();

            return text;
        }

        public static string Ceaser(int k, string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (char.IsUpper(s[i]))
                    {
                        int a = (s[i] - 64 + k) % 26 + 64;
                        result += (char)a;
                    }
                    else
                    {
                        int A = (s[i] - 96 + k) % 26 + 96;
                        result += (char)A;
                    }
                }
                else
                {
                    result+= s[i];
                }
                
            }

            return result;
        }

        public static string AntiCeaser(int k, string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (char.IsUpper(s[i]))
                    {
                        int a = (s[i] - 64 - k) % 26 + 64;

                        if (a <= 64)
                        {
                            a = a + 26;
                            
                        }
                        result += (char)a;
                    }
                    else
                    {
                        int A = (s[i] - 96 - k) % 26 + 96;

                        if (A <= 96)
                        {
                            A = A + 26;
                            
                        }
                        result += (char)A;
                    }
                }
                else
                {
                    result += s[i];
                }
            }

            return result;
        }

        internal static string DifferenceTime(string time1, string time2)
        {
            int h1 = int.Parse(time1.Substring(0, 2));
            int m1 = int.Parse(time1.Substring(3, 2));
            int s1 = int.Parse(time1.Substring(6, 2));

            int h2 = int.Parse(time2.Substring(0, 2));
            int m2 = int.Parse(time2.Substring(3, 2));
            int s2 = int.Parse(time2.Substring(6, 2));

            //int difference = h2 * 3600 + m2 * 60 + s2 - (h1 * 3600 + m1 * 60 + s1);

            //return $"{(difference / 3600).ToString().PadLeft(2, '0')}:{((difference % 3600) / 60).ToString().PadLeft(2, '0')}:{(difference % 60).ToString().PadLeft(2, '0')}";

            int diff = h2 * 60 + m2 + s2 / 60 - (h1 * 60 + m1 + s1 / 60);

            return $"{(diff / 60).ToString().PadLeft(2, '0')}:{(diff % 60).ToString().PadLeft(2, '0')}:{((diff % 60) % 60).ToString().PadLeft(2, '0')}";
        }




        internal static string AddTime()
        {
            Console.Write("Bashlama saatini qeyd edin: ");
            string time1 = Console.ReadLine();

            return time1;
        }

        internal static string EndTime()
        {
            Console.Write("Bitme saatini qeyd edin: ");
            string time2 = Console.ReadLine();

            return time2;
        }
    }
}
