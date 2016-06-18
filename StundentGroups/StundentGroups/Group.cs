

namespace StundentGroups
{
   
    public class Group
    {
        
        public int GroupNumber { get; set; }

        public Departments DepartmentName { get; set; }

        public Group( Departments name)

        {
            this.DepartmentName = name;
            this.GroupNumber = (int)this.DepartmentName;


        }

        public Group()
        {
        }


       
    }
}
