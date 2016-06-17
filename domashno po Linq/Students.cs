


namespace domashno_po_Linq
{
    
    public class Students
    {    
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public int Age { get; set; }

        public Students(string name,string lastname)
        {
            this.FirstName = name;
            this.LastName = lastname;
        }

        public Students(string name, string lastname,int age):this(name,lastname)
        {
            this.Age = age;
        }
    }
}
