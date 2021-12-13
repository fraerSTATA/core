using System;
using System.IO;
using System.Text;

namespace core
{
    public abstract class LogAbstract
    {
        protected string FormatLog(string[] strings)
        {
            return string.Join(";\n\r", strings);
        }

        protected void WriteConsole(string s)
        {
            Console.WriteLine(s);
        }

        protected void WriteConsole(string[] s)
        {
            Console.WriteLine(FormatLog(s));
          
            
        }
    }
}
