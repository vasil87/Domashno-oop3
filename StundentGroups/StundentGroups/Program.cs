

namespace StundentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            List<Students> bazadanni = new List<Students>();

            for (int i = 0; i < 150; i++)
            {
                bazadanni.Add(new Students("Student" + i, "Familia" + i * i, i % 10));
                string a = string.Empty ;
                string b = string.Empty;
                switch (i % 10)
                {
                    case 0: a = "abv.bg";break;
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
                bazadanni[i].Email = "Student" + i+ "Familia" + i * i+ "@" + a;

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
                    Random top3 = new Random(i+int.Parse(DateTime.Now.Millisecond.ToString())+i* int.Parse(DateTime.Now.Millisecond.ToString()));

                bazadanni[i].Tel = b+"/"+ top.Next(111111, 999999);

                bazadanni[i].FN = top3.Next(111111, 999999);

                for (int j = 0; j < 3; j++)
                {
                    Random top2 = new Random(j+top.Next(1 ,110010110));

                    bazadanni[i].Marks.Add(top2.Next(2, 7));
                }
                for (int j = 0; j < 5; j++)
                {
                    Random top2 = new Random(j + top3.Next(1, 110010110));

                    Departments z = new Departments();
                    
                    switch(top2.Next(0,5))

                    {
                        case 0: z = Departments.Mathemathics; break;
                        case 1: z = Departments.Biology; break;
                        case 2: z = Departments.Physics; break;
                        case 3: z = Departments.IT; break;
                        case 4: z = Departments.Music; break;
                    }

                    bazadanni[i].GroupNumber.DepartmentName = z;
                    bazadanni[i].GroupNumber.GroupNumber = (int)(z);
                }



            }

            //var masivEmails =
            //    (from student in bazadanni
            //     where student.Email.Contains("@abv.bg")
            //     select student);



            // bazadanni= bazadanni.OrderByDescending(x => x.FirstName).ToList();

            //bazadanni =
            //    (from students in bazadanni
            //     orderby students.FirstName descending
            //     select students).ToList();
            //
            // for (int i = 0; i < 150; i++)
            // {
            //     Console.WriteLine(bazadanni[i].FirstName + " " + bazadanni[i].LastName+ " "+bazadanni[i].GroupNumber);
            //
            // }
            //

            // var newlist =
            //     from student in bazadanni
            //     where student.GroupNumber == 2
            //     select student.FirstName + " " + student.LastName;
            //
            //

            // var newlist = bazadanni.Where(x => x.GroupNumber == 2).OrderByDescending(x =>x.FirstName);

            //var telnumber =
            //    (from student in bazadanni
            //     where student.Tel.Contains("02/")
            //     select student);

            //var marksMasiv =
            //    (from student in bazadanni
            //     where student.Marks.Any(x => x == 6)  
            //     select student.FirstName+" "+student.LastName+" "+student.Marks.First(x=>x==6));

            //var marksMasiv = bazadanni.Where(x => x.Marks.Count(y => y == 6) >= 2);

            // var FnMasiv = bazadanni.Where(x => (x.FN) % 100 == 06);
            // var MathematicsMasiv = bazadanni.Where(x => x.GroupNumber.DepartmentName == Departments.Mathemathics)
            //
            // foreach (var item in MathematicsMasiv)
            // 
            //  {
            //       Console.Write(item.FirstName+" "+item.LastName+" "+item.Email+ " "+ item.Tel+ " ");
            //
            //     for (int i = 0; i < item.Marks.Count;i++)
            //     {
            //         Console.Write(item.Marks[i] + " ");
            //     }
            //
            //     Console.Write(item.FN);
            //     Console.Write(" " + item.GroupNumber.DepartmentName + " " + item.GroupNumber.GroupNumber);
            //
            //     Console.WriteLine();
            // }



            //foreach (var item in marksMasiv)
            //
            //{
            //    Console.WriteLine(item);
            //}
            //


            // var byGropuNumber =
            //     from students in bazadanni
            //     group students by students.GroupNumber.GroupNumber into g 
            //     orderby g.Key
            //     select g;
            //
            //
            // foreach (var item in byGropuNumber)
            // {
            //     Console.WriteLine(item.Key);
            //     foreach (var gh in item)
            //     {
            //         Console.WriteLine(gh.FirstName + " " + gh.LastName + " " + gh.GroupNumber.GroupNumber);
            //     }
            // }

            var byGroupNumber = bazadanni.GroupBy(x => x.GroupNumber.GroupNumber).OrderBy(y=>y.Key);

            foreach (var item in byGroupNumber)
            {
                Console.WriteLine(item.Key);
                foreach (var gh in item)
                {
                    Console.WriteLine(gh.FirstName + " " + gh.LastName + " " + gh.GroupNumber.GroupNumber);
                }
            }

        }
    }
}
