using System;

namespace day_12
{
    abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Course { get; set; }

        public Person()
        {
            Console.WriteLine("Enter lastname :");
            LastName = Check.CheckString();
            Console.WriteLine("Enter name :");
            Name = Check.CheckString();
            Console.WriteLine("Na kakom kurse ucites?");
            Course = Check.CheckInt();
        }
        public abstract void InputData();

        class Student : Person
        {
            
            public Student() : base()
            {                                
            }
            public override void InputData()
            {
                Console.WriteLine($"{LastName} {Name} ucitsa na {Course}om kurse.");

            }

        }
        class Aspirant : Person
        {
            string Diss { get; set; }
            public Aspirant()
                : base( )
            {
                Console.WriteLine("Thesis :");
                this.Diss = Check.CheckString();
            }
            
            public override void InputData()
            {
                Console.WriteLine($"Student {LastName} {Name} ucitsa {Course}om kurse. Dissertaciya : {Diss}");
            }
        }

        class Check
        {
            public static string CheckString()
            {
                bool IsIt = false;
                string name;
                do
                {
                    name = Console.ReadLine();
                    int count = 0;
                    
                            for (int i = 0; i < name.Length; i++)
                            {

                                for (int j = 0; j <= 9; j++)
                                {
                                    if (name[i] == j.ToString()[0])
                                    {
                                        IsIt = false;
                                        count++;
                                        break;
                                    }
                                    if (name[i] == ' ')
                                    {
                                        IsIt = false;
                                        count++;
                                        break;
                                    }
                                    if (count == 0)
                                        IsIt = true;
                                } 
                            }

                        if (IsIt == false)
                            Console.WriteLine("Wrong input. Enter again : ");
                    }while (IsIt == false);
                return name;
                
            }
                public static int CheckInt()
                {
                    bool IsIt = false;
                    int num;
                    do
                    {
                        string input = Console.ReadLine();

                        bool result = int.TryParse(input, out num);
                        if (result == false)
                            Console.WriteLine("Wrong input. Enter again : ");
                        else
                            break;
                    } while (IsIt == false);
                    return num;
                }
            }
        class Program
        {
            static void Main(string[] args)
            {
                Student st = new Student();
                st.InputData();
                Aspirant asp = new Aspirant();
                asp.InputData();
                //Console.WriteLine("1.Register students:" +
                //    //"\n2.Show all registered students:" +
                //    //"\n3.Find student:" +
                //    "\n4.Exit:");

                ////int count1 = 0;
                ////int count2 = 0;


                //bool b = false;
                //do
                //{
                //    bool b1 = false;

                //    Console.WriteLine("Select number of menu:");
                //    int menu = Check.CheckInt();
                //    switch (menu)
                //    {
                //        case 1:
                //            do
                //            {
                //                Console.WriteLine("Are you:" +
                //                    "\n1.Student" +
                //                    "\n2.Graduate student");

                //                int m = Check.CheckInt();
                //                if (m == 1)
                //                {
                //                    Student st = new Student();
                //                    st.InputData();
                //                    //for (int i = 0; i < count1; i++)
                //                    //{

                //                    //}
                //                    b1 = true;
                //                    break;
                //                }

                //                if (m == 2)
                //                {
                //                    Aspirant asp = new Aspirant();
                //                    asp.InputData();
                //                    //for (int i = 0; i < count2; i++)
                //                    //{

                //                    //}
                //                    //b1 = true;
                //                    break;
                //                }

                //            } while (b1 == false);
                //            break;
                //case 2:
                //    for (int i = 0; i < count1; i++)
                //    {
                //        st.Info();
                //    }
                //    for (int i = 0; i < count2; i++)
                //    {
                //        asp.DisplayA();
                //    }
                //    break;
                //case 3:
                //    do
                //    {
                //        Console.WriteLine("Input who want you to search: Student (stud) or graduate student (asp) ?");
                //        string who = Console.ReadLine();
                //        if (who == "stud" || who == "Stud")
                //        {
                //            Console.WriteLine("Enter student's number:");
                //            int num = Check.CheckInt();
                //            if (st[num - 1] == null)
                //            {
                //                Console.WriteLine("There aren't any students.");
                //            }
                //            else
                //            {
                //                st[num - 1].Display();
                //            }
                //            b1 = true;
                //        }
                //        else if (who == "asp" || who == "Asp")
                //        {
                //            Console.WriteLine("Enter graduate student's number:");
                //            int num = Check.CheckInt();
                //            if (asp[num - 1] == null)
                //            {
                //                Console.WriteLine("There aren't any graduate students.");
                //            }
                //            else
                //            {
                //                asp[num - 1].DisplayA();
                //            }
                //            b1 = true;
                ///        }
                //        else
                //        {
                //            Console.WriteLine("Wrong enter, try again.");
                //            b1 = false;
                //        }
                //    } while (b1 == false);
                //    break;
                //        case 4:
                //            Console.WriteLine("The program has finished.");
                //            b = true;
                //            break;
                //    }
                //} while (b == false);
            }
        }
    }
}
