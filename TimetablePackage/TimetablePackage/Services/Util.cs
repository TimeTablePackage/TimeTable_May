using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class Util
    {
        public bool containsSlot(string theSlot, string theList)
        {
            bool answer = false;
            while (theSlot != null)
            {
                if (theSlot == (theList = theList.Substring(0, theList.IndexOf(":")))) 
                {
                    answer = true;
                } 
            }
            return answer;
        }

    }
}
