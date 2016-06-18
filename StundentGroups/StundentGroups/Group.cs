



namespace StundentGroups
{
    using System;
    using System.Linq;

    public class Group
    {
        private int? groupNumner;

        public int? GroupNumber
        {
            get
            {
                return this.groupNumner;
            }

            set
            {
                if (value < 0) throw new ArgumentException("Group number can`t be negative ");
                if (value > 20) throw new ArgumentException("GroupNumber should be no more than 20 ");
                if (value.ToString().Any(x => char.IsLetter(x))) throw new ArgumentException("GroupNumber should be only digits");
                this.groupNumner = value;
            }
        }


        public Departments DepartmentName { get; set; }

        public Group(int? group, Departments name)

        {
            this.DepartmentName = name;
            this.GroupNumber = group;


        }

        public Group()
        {
            this.DepartmentName = Departments.None;
            this.GroupNumber = null;
        }




    }
}
