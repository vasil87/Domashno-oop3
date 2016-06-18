

namespace domashno_po_Linq
{
    
   
    using System.Linq;
  
    public static class ExtensionsForStudents
    {
        public static Students[] FirstBeforeLast(this Students[] array)
            
        {

            var result =
                (from item in array
                 where item.FirstName.ToLower().CompareTo(item.LastName.ToLower()) < 0
                 select item).ToArray();

            return result;
            
        }

        public static string[] Age(this Students[] array)

        {
            
            var result =
                (from item in array
                 where (item.Age>=18 && item.Age<=24)
                 select item.FirstName +" "+ item.LastName+ " " +item.Age).ToArray();

            return result;

        }

    }
}
