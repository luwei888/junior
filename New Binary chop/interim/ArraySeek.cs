using System;
using System.Collections.Generic;
using System.Text;

namespace interim
{
    internal class ArraySeek
    {
        //internal BinarySeek Seeker { get; set; }
        internal void Target(BinarySeek binarySeek,int matcher)
        {
            binarySeek.Do(matcher);
        }
    }
}
