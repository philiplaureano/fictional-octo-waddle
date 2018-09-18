using System;
using System.Text;

namespace LegacyCodeLibrary
{
    public class Formatter
    {
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
    }
}