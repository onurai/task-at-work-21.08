using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace task_at_work_21._08
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("would you like to get brief info about cats ? ");
        //    string answer1 = "yes";     
        //    Console.WriteLine("please enter your desicion: yes or no ");
        //    string answer3 = Console.ReadLine();

        //    if (answer1 == answer3)
        //    {
        //        Console.WriteLine("218 kittens were born by the oldest cat");
        //    }           
        //    else
        //    {
        //        Console.WriteLine("i am not interested in them");
        //        Console.WriteLine("please select the reason");
        //        Console.WriteLine("1", "2", "3");
        //        int a = int.Parse(Console.ReadLine());
        //        switch (a)
        //        {
        //            case 1:
        //                Console.WriteLine("It is not eligible");
        //                break;
        //            case 2:
        //                Console.WriteLine("Too many ads");
        //                break;
        //            case 3:
        //                Console.WriteLine("Stop showing this");
        //                break;                   
        //            default:
        //                Console.WriteLine("Sehven elim deydi");
        //                break;
        //        }
        //    }                      
        //}



        //static void Main(string[] args)
        //{
        //    Employee person = new Employee
        //    {
        //        name = "onur",
        //        surname = "ibadov",
        //        id = 1
        //    };
        //    Employee person1 = new Employee { name = "perviz" };
        //    Employee person2 = new Employee { name = "turkan" };
        //    Employee person3 = new Employee { name = "fidan" };
        //    Employee person4 = new Employee { name = "eli" };


        //    Employee[] persons = new Employee[] { person, person1, person2, person3, person4 };

        //    foreach (Employee i in persons)
        //    {
        //        Console.WriteLine(i.name);
        //    }
        //}
        //class Employee
        //{
        //    public string name;
        //    public string surname;
        //    public int id;
        //}






        #region    Json, ASYNC, and DESERIALIZED
        //static async Task Main(string[] args)


        //    string url = "https://catfacts.ninja/facts";
        //    HttpClient client = new HttpClient();
        //    bool IsContinued;

        //    Console.WriteLine("show me some facts");


        //    do
        //    {
        //        var cavab = await client.GetStringAsync(url);

        //        var Deserailizedfact = JsonConvert.DeserializeObject<CatsFacts>(cavab);
        //        Console.WriteLine(Deserailizedfact.facts);

        //        IsContinued = Convert.ToBoolean(Console.ReadLine());                
        //    }
        //    while (IsContinued) ;
        //}

        //class CatsFacts
        //{
        //    public string facts { get; set; }

        //    public int length { get; set; }
        #endregion





        static void Main(string[] args)
        {     
            Student student = new Student();
            student.name = "onur";
            student.surname = "surname";
            student.age = 23;
            {
                new Parent
                {
                    name = "ata",
                    surname = "atayev",
                    PhoneNumber = 555-55-55
                };
                new Parent
                {
                    name = "ana",
                    surname = "anayeva",
                    PhoneNumber = 555-55-55
                };
            }

            Teacher teacher = new Teacher();
            teacher.name = "turxay";
            teacher.surname = "mammadov";
            teacher.DateOfBirth = new DateTime(1996, 05, 24);
        }

        var Jsonresult = JsonConvert.SerializeObject(student);
        Console.WriteLine(Jsonresult);




        class Student
        {
            public string name { get; set; }
            public string surname { get; set; }
            public int age { get; set; }
            public Parent [] parents { get; set; }
            public Teacher [] teacher { get; set; }



        }
        class Parent
        {
            public string name { get; set; }
            public string surname { get; set; }
            public int PhoneNumber { get; set; }
        }

        class Teacher
        {
            public string name { get; set; }
            public string surname { get; set; }
            public DateTime DateOfBirth { get; set; }
        }

    }
}
