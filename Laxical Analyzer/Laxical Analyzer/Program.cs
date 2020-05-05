using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laxical_Analyzer
{
    class Program
    {
        class lexical
        {
           public string[] keywords = { "abstract", "as", "base", "bool", "break", "by",
            "byte", "case", "catch", "char", "checked", "class", "const",
            "continue", "decimal", "default", "delegate", "do", "double",
            "descending", "explicit", "event", "extern", "else", "enum",
            "false", "finally", "fixed", "float", "for", "foreach", "from",
            "goto", "group", "if", "implicit", "in", "int", "interface",
            "internal", "into", "is", "lock", "long", "new", "null", "namespace",
            "object", "operator", "out", "override", "orderby",  "params",
            "private", "protected", "public", "readonly", "ref", "return",
            "switch", "struct", "sbyte", "sealed", "short", "sizeof",
            "stackalloc", "static", "string", "select",  "this",
            "throw", "true", "try", "typeof", "uint", "ulong", "unchecked",
            "unsafe", "ushort", "using", "var", "virtual", "volatile",
            "void", "while", "where", "yield" };

            public string[] separator = { ";", "{", "}", "\r", "\n", "\r\n" };

           public string[] comments = { "//", "/*", "*/" };

           public string[] operators = { "+", "-", "*", "/", "%", "&","(",")","[","]",
            "|", "^", "!", "~", "&&", "||",",",
            "++", "--", "<<", ">>", "==", "!=", "<", ">", "<=",
            ">=", "=", "+=", "-=", "*=", "/=", "%=", "&=", "|=",
            "^=", "<<=", ">>=", ".", "[]", "()", "?:", "=>", "??" };
        }
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Input : ");
            input = Console.ReadLine();
            lexical lex = new lexical();

        for(int i =0;i<lex.keywords.Length;i++)
        {
            char[] lexen;
            if(input==lex.keywords[i])
            {
                
                lexen=input.ToCharArray(0,input.Length);
                for (int j = 0; j < input.Length;j++ )
                {
                    Console.WriteLine("Read ---> "+lexen[j]); 

                }
                Console.WriteLine("Token Generated To '"+input+"'");
            }
        }
        for (int i = 0; i < lex.separator.Length; i++)
        {
            char[] character;
            if (input == lex.separator[i])
            {
                character = input.ToCharArray(0, input.Length);
                for (int j = 0; j < input.Length; j++)
                {
                    Console.WriteLine("Read ---> " + character[j]);

                }
                Console.WriteLine("Token Generated To '" + input + "'");
            }
        }
        for (int i = 0; i < lex.operators.Length; i++)
        {
            char[] character;
            if (input == lex.operators[i])
            {
                character = input.ToCharArray(0, input.Length);
                for (int j = 0; j < input.Length; j++)
                {
                    Console.WriteLine("Read ---> " + character[j]);

                }
                Console.WriteLine("Token Generated To '" + input + "'");
            }
        }
        for (int i = 0; i < lex.comments.Length; i++)
        {
            char[] character;
            if (input == lex.comments[i])
            {
                character = input.ToCharArray(0, input.Length);
                for (int j = 0; j < input.Length; j++)
                {
                    Console.WriteLine("Read ---> " + character[j]);

                }
                Console.WriteLine("Token Generated To '" + input + "'");
            }
        }
        Console.ReadLine();
        }
    }
}
