

namespace domashno_po_Linq
{
    using System;
    using System.Text;
   
    public static class StringBuilderSubstring
    {    public static StringBuilder Substring(this StringBuilder abc, int startIndex)
        {
            return abc.Substring(startIndex, abc.Length - startIndex );
        }
       public static StringBuilder Substring(this StringBuilder abc,int startIndex,int length)
        {
            StringBuilder temporary = new StringBuilder();

            int endindex = startIndex + length - 1;

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("startIndex","startIndex is smaller than 0");
            }
            if (startIndex > abc.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex", "StartIndex Larger Than Length");
            }
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("length", "Negative Length");
            }
            if (startIndex > abc.Length - length)
            {
                throw new ArgumentOutOfRangeException("length", "String Length is lesser than startindex+length");
            }
            if (length == 0)
            {
                return new StringBuilder() ;
            }
            if (startIndex == 0 && length == abc.Length)
            {
                return abc;
            }


            for (int i = startIndex; i <= endindex; i++)
            {
                temporary.Append(abc[i]);
            }


            return temporary;

           
        }
        
    }
}
