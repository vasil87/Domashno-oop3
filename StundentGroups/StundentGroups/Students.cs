

//FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
namespace StundentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Students
    {

        public Students(string firstname, string lastname)
        {

            this.FirstName = firstname;
            this.LastName = lastname;
            this.GroupNumber = 10;
            this.FN = 100000;
            this.Email = "unkown@abv.bg";
            this.Marks = new List<double>();
            this.Tel = "000000";
        }

        private string firstName;
        private string lastName;
        private int fN;
        private string email;
        private List<double> marks;
        private string tel;
        private int? groupNumber;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("First name should not be empty");
                this.firstName = value;
            }

        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Last name should not be empty");
                this.lastName = value;
            }

        }
        public int FN
        {
            get
            {
                return this.fN;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Fakulty number can`t be negative ");
                if (value.ToString().Length != 6) throw new ArgumentException("Fakulty number should be exactly 6 digits long");
                if (value.ToString().Any(x => char.IsLetter(x))) throw new ArgumentException("Fakulty number should be only digits");
                this.fN = value;
            }

        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Email should not be empty");
                this.email = value;
            }

        }

        public List<double> Marks
        {
            get
            { return this.marks; }
            set
            {
                if (value.Any(x => x.ToString().Any(y => char.IsLetter(y))))
                    throw new ArgumentException("marks cannot be letters");
                if (value.Any(x => x.ToString().Count() > 1))
                    throw new ArgumentException("marks cannot be more than one digit");
                if (value.Any(x => x < 2 || x > 6))
                    throw new ArgumentException("marks should be in the range 2-6");
                this.marks = value;
            }
        }

        public int? GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                if (value < 0) throw new ArgumentException("Group number can`t be negative ");
                if (value.ToString().Length > 2) throw new ArgumentException("GroupNumber should be no more than 2 digits long");
                if (value.ToString().Any(x => char.IsLetter(x))) throw new ArgumentException("GroupNumber should be only digits");
                this.groupNumber = value;
            }
        }
        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Tel should not be empty");
                this.tel = value;
            }

        }

        public override string ToString()
        {
            return string.Join(" ", this.FirstName, this.LastName, this.groupNumber, string.Join(" ", this.Marks));
        }
    }
}
