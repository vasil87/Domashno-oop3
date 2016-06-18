

namespace StundentGroups
{

    
    using System.Linq;


    public class LongestString
    {
        public static string Longest(string[] vhod)
        {
            

            var result = vhod.FirstOrDefault(y=>y.Length==vhod.Max(x => x.Length));

            return result;

        }
    }
}
