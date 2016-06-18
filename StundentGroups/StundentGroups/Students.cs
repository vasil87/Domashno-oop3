using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
namespace StundentGroups
{
    public class Students
    {
        public Students(string firstname, string lastname, int groupnumber)
        {
            this.GroupNumber = new Group();
            this.FirstName = firstname;
            this.LastName = lastname;
            this.GroupNumber.GroupNumber = groupnumber;
            this.FN = 0;
            this.Email = null;
            this.Marks = new List<double>();
            this.Tel = null;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; }

        public string Email { get; set; }

        public List<double> Marks { get; set; }

        public Group GroupNumber { get; set; }

        public string Tel { get; set; }


    }
}
