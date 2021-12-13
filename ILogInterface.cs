using System;
using System.Collections.Generic;
using System.Text;

namespace core
{
    public interface ILogInterface
    {
        ILogInterface Log(string str);
        ILogInterface Write();
    }
} 
