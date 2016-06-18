

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

            nov.Append("Imalo edno vreme na zapad");

            nov2 = nov.Substring(4,5);                          // Problem.1 StringBuilder.Substring

            Console.WriteLine(string.IsNullOrEmpty(nov2.ToString()));
            Console.WriteLine(nov2);

            Console.WriteLine();

            int[] masivSusDanni = new int[7] { -13451, 23455, 3453, 344, 3534, 5545, 4465 };

            Console.WriteLine("Product :{0}", masivSusDanni.Product());                  //Problem 2. IEnumerable extensions
            Console.WriteLine("Sum :{0}", masivSusDanni.Sum());
            Console.WriteLine("Sum :{0:F2}", masivSusDanni.Average());
            Console.WriteLine("Sum :{0}", masivSusDanni.Min());
            Console.WriteLine("Sum :{0}", masivSusDanni.Max());

            Console.WriteLine();

            Students petur = new Students("Aleskandur", "Petrov", 19);
            Students stoqn = new Students("Stoqn", "Aetrov", 23);
            Students stoqn2 = new Students("Petur", "Zetrov", 35);
            Students stoqn3 = new Students("Petur", "Vetrov", 35);

            Students[] masiv = new Students[] { petur, stoqn, stoqn2, new Students("Asan", "Hasan"), stoqn3 };

            var result = masiv.FirstBeforeLast();                         //Problem 3. First before last

            foreach (var item in result)

            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();

            var ageResult = masiv.Age();                                   //Problem 4. Age range

            Print(ageResult);

            Console.WriteLine();
                                                                         //Problem 5. Order students
            var masivOrdered = masiv.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName); 
                        
            foreach (var item in masivOrdered)

            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
              
            var orderedBy =                                              //Problem 5. Order students
                (from item in masiv  
                 orderby item.FirstName descending
                 , item.LastName descending
                 select item.FirstName + " " + item.LastName).ToArray();

            Print(orderedBy);
        }

        private static void Print(string[] ageResult)
        {
            foreach (var item in ageResult)

            {
                Console.WriteLine(item);
            }
        }
    }
}
