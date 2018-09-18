using System;
using System.Text;

namespace SampleLegacyConsoleApp
{
    class Program
    {
        // CHALLENGE #1: How would you document what this method does?
        // CHALLENGE #2: How do you change it with 100% confidence that it works the same way as it did before?
        public static String FormatText(String text)
        {
            var stringBuffer = new StringBuilder();
            
            for (int n = 0; n < text.Length; ++n) {
                int c = text[n];
                if (c == '<') {
                    while(n < text.Length && text[n] != '/' && text[n] != '>')
                        n++;
                    if (n < text.Length && text[n] == '/')
                        n+=4;
                    else
                        n++;
                }
                if (n < text.Length)
                    stringBuffer.Append(text[n]);
            }
            return stringBuffer.ToString();
        }
        
        static void Main(string[] args)
        {
            // TODO: How would you test this code?             
            Console.WriteLine(FormatText("<test/>"));
            
            return;
        }
    }
}