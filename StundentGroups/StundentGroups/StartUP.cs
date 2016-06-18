

namespace StundentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    
    class StartUP
    {
        static void Main()
        {
            List<Students> bazadanni = new List<Students>();

            PopulvaneNaDanni(bazadanni);

            List<Group> grupi = new List<Group>();

            SomeGroups(grupi);


            var newlistGroup2Linq =                         //problem.9
                from student in bazadanni
                where student.GroupNumber == 2
                orderby student.FirstName
                select new { FamilyName = student.FirstName + " " + student.LastName, Group = student.GroupNumber };

            Print(newlistGroup2Linq, "problem9");


            var newlistGroup2Ext = bazadanni                 //problem.10
            .Where(x => x.GroupNumber == 2)
            .OrderByDescending(x => x.FirstName);

            Print(newlistGroup2Ext, "problem.10");


            var masivemMails =                                //problem.11
                (from student in bazadanni
                 where student.Email.Contains("@abv.bg")
                 select student.ToString());

            Print(masivemMails, "problem.11");


            var masivByTelNumber =                                    //problem.12
                (from student in bazadanni
                 where student.Tel.Contains("02/")
                 select student);

            Print(masivByTelNumber, "problem.12");

            var masivAny6 =                                            //problem 13
                 from student in bazadanni
                 where student.Marks.Any(x => x == 6)
                 select
                 new { FullName = student.FirstName + " " + student.LastName, Marks = string.Join(" ", student.Marks) };

            Print(masivAny6, "problem 13");

            var masivTwoX2 = bazadanni                                  //problem 14
                .Where(x => x.Marks.Count(y => y == 2) == 2)
                .Select(y => new { FullName = y.FirstName + " " + y.LastName, Marks = string.Join(" ", y.Marks) });

            Print(masivTwoX2, "problem 14");

            var masivBy2006 = bazadanni                                 //problem 15
               .Where(x => (x.FN) % 100 == 06)
               .Select(y => new { FullName = y.FirstName + " " + y.LastName, Marks = string.Join(" ", y.Marks), FN = y.FN });

            Print(masivBy2006, "problem 15");


            var MathematicsMasiv = grupi.Where(z => z.DepartmentName == Departments.Mathemathics)            //problem 16
                .AsQueryable().Join(bazadanni,
                y => y.GroupNumber,
                x => x.GroupNumber,
                (y, x) => new { FullName = x.FirstName + " " + x.LastName, Marks = string.Join(" ", x.Marks), Department = y.DepartmentName });


            Print(MathematicsMasiv, "problem 16");

            string[] vhod = new string[150];                                        //problem17

            Console.WriteLine("problem17");

            for (int i = 0; i < 150; i++)
            {
                Random top = new Random(i * i + i * i * i);

                vhod[i] = new string((char)top.Next(65, 91), top.Next(5, 20));


            }


            Console.WriteLine(LongestString.Longest(vhod));



            var masivByGroupNumber =                                              //problem18
                from students in bazadanni
                group students by students.GroupNumber into g
                orderby g.Key
                select g;

            Console.WriteLine("problem18");
            foreach (var item in masivByGroupNumber)
            {
                Console.WriteLine(item.Key);
                foreach (var element in item)
                {
                    Console.WriteLine(element.FirstName + " " + element.LastName + " " + element.GroupNumber);
                }
            }

            var masivByGroupNumberExtensions = bazadanni                             //problem19
                .GroupBy(x => x.GroupNumber)
                .OrderBy(y => y.Key);

            Console.WriteLine("problem19");

            foreach (var item in masivByGroupNumberExtensions)
            {
                Console.WriteLine(item.Key);
                foreach (var element in item)
                {
                    Console.WriteLine(element.FirstName + " " + element.LastName + " " + element.GroupNumber);
                }
            }

            Console.WriteLine("problem 20");

            Function StepenNaDve = delegate (int index)
              {

                  return 1 / Math.Pow(2, index);
              };

            Console.WriteLine("Function 1+1/2+1/4+1/8+1/16...= {0}",Convergent.Sum(StepenNaDve, 0.01));

            Function StepenNaDveSusRazlichenZnak = delegate (int index)
            {

               
                    return index%2==0? 1 / Math.Pow(2, index):(-1 / Math.Pow(2, index));
                
            };

            Console.WriteLine("Function 1-1/2+1/4-1/8+1/16....= {0}", Convergent.Sum(StepenNaDveSusRazlichenZnak, 0.0000001));


        }

        private static void PopulvaneNaDanni(List<Students> bazadanni)
        {
            for (int i = 0; i < 150; i++)
            {
                bazadanni.Add(new Students("Student" + i, "Familia" + i * i));
                string a = string.Empty;
                string b = string.Empty;
                switch (i % 10)
                {
                    case 0: a = "abv.bg"; break;
                    case 1: a = "gmail.com"; break;
                    case 2: a = "vasil.com"; break;
                    case 3: a = "yahoo.com"; break;
                    case 4: a = "email.de"; break;
                    case 5: a = "bgcoder.com"; break;
                    case 6: a = "telerik.com"; break;
                    case 7: a = "azsumposhta.net"; break;
                    case 8: a = "dir.bg"; break;
                    case 9: a = "data.bg"; break;

                }
                bazadanni[i].Email = "Student" + i + "Familia" + i * i + "@" + a;


                switch (i % 10)
                {
                    case 0: b = "02"; break;
                    case 1: b = "056"; break;
                    case 2: b = "0888"; break;
                    case 3: b = "054"; break;
                    case 4: b = "0227"; break;
                    case 5: b = "0456"; break;
                    case 6: b = "0785"; break;
                    case 7: b = "052"; break;
                    case 8: b = "0547"; break;
                    case 9: b = "055"; break;

                }


                Random top = new Random(i);

                bazadanni[i].Tel = b + "/" + top.Next(111111, 999999);

                Random top3 = new Random(i + int.Parse
                    (DateTime.Now.Millisecond.ToString()) + i * int.Parse(DateTime.Now.Millisecond.ToString()));

                bazadanni[i].FN = top3.Next(111111, 999999);

                for (int j = 0; j < 3; j++)
                {
                    Random top2 = new Random(j + top.Next(1, 110010110));

                    bazadanni[i].Marks.Add(top2.Next(2, 7));
                }

                Random top4 = new Random(top.Next(top.Next(56465456) + top3.Next(1, 110010110)));

                bazadanni[i].GroupNumber = top4.Next(0, 21);





            }
        }


        public static void SomeGroups(List<Group> grupi)
        {
            for (int j = 0; j < 20; j++)
            {
                Random top4 = new Random(j + j * j + j * j * j);

                Departments z = new Departments();

                switch (top4.Next(0, 5))

                {
                    case 0: z = Departments.Mathemathics; break;
                    case 1: z = Departments.Biology; break;
                    case 2: z = Departments.Physics; break;
                    case 3: z = Departments.IT; break;
                    case 4: z = Departments.Music; break;
                }

                grupi.Add(new Group(top4.Next(0, 21), z));

            }

        }

        private static void Print<T>(IEnumerable<T> masiv, string message)
        {
            int count = 0;
            Console.WriteLine(message);
            foreach (T item in masiv)
            {
                Console.WriteLine(item + " ");
                if (count % 5 == 0) Console.WriteLine();
                count++;

            }
            if (!(count % 6 == 0))
                Console.WriteLine();
        }

    }
}
