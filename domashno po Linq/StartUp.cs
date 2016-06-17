

namespace domashno_po_Linq
{
    using System;
    using System.Text;
    using System.Linq;

 
    class StartUp
    {
        static void Main()
        {

            StringBuilder nov = new StringBuilder();
            StringBuilder nov2 = new StringBuilder();

            nov.Append("VASIL");

            nov2 = nov.Substring(4);
            Console.WriteLine(string.IsNullOrEmpty(nov2.ToString()));
            Console.WriteLine(nov2);

            int[] vasil2 = new int[7] { -13453451, 2345345, 353453,3454, 34534, 545345 ,466465};

            Console.WriteLine(vasil2.Product());

            Students petur = new Students("Aleskandur", "Petrov",19);
            Students stoqn = new Students("Stoqn", "Aetrov",23);
            Students stoqn2 = new Students("Petur", "Zetrov",35);
            Students stoqn3 = new Students("Petur", "Vetrov", 35);

            Students[] masiv = new Students[] { petur, stoqn, stoqn2,new Students("Asan" ,"Hasan"),stoqn3};
            var result = masiv.FirstBeforeLast();

           foreach (var item in result)
           
           {
               Console.WriteLine(item.FirstName + " " + item.LastName);
           }

            Console.WriteLine();

            var ageResult = masiv.Age();

            foreach (var item in ageResult)

            {
                Console.WriteLine(item);
            }

            var masivOrdered=masiv.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName);

            Console.WriteLine();

            foreach (var item in masivOrdered)

            {
                Console.WriteLine(item.FirstName+" " +item.LastName);
            }

            Console.WriteLine();

            var orderedBy =
                (from item in masiv
                 orderby item.FirstName descending
                 ,item.LastName descending
                 select item.FirstName + " " + item.LastName).ToArray();

            foreach (var item in orderedBy)

            {
                Console.WriteLine(item);
            }
        }
    }
}
