using System;
using System.Collections;

namespace day_12
{
    abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Course { get; set; }

        public Person()
        {
            Console.WriteLine("Фамилия :");
            LastName = Check.CheckString();
            Console.WriteLine("Имя :");
            Name = Check.CheckString();
            Console.WriteLine("Курс :");
            Course = Check.CheckInt();
        }
        public abstract void GetData();
    }

    
        class Student : Person
        {
            
            public Student() : base()
            {                                
            }
            public override void GetData()
            {
                Console.WriteLine($"{LastName} {Name} учиться в {Course}ом курсе.");

            }

        }
    class Aspirant : Person
        {
            public int Diss { get; set; }
            public Aspirant()
                : base( )
            {
                Console.WriteLine("Номер диссертации :");
                this.Diss = Check.CheckInt();
            }
            
            public override void GetData()
            {
                Console.WriteLine($"Аспирант {LastName} {Name} учиться в {Course}ом курсе. Номер диссертации : {Diss}");
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
                            Console.WriteLine("Неправильный ввод. Введите снова : ");
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
                            Console.WriteLine("Неправильный ввод. Введите снова : ");
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
            Console.WriteLine("1.Регистрация студентов :" +
                            "\n2.Информация о студентах :" +
                            "\n3.Удаление из списка студентов :" +
                            "\n4.Выход :");

            ArrayList students = new ArrayList();
            ArrayList g_students = new ArrayList();

            bool b = false;
            do
            {
                bool b1 = false;

                Console.WriteLine("Выберите номер меню :");
                int menu = Check.CheckInt();
                switch (menu)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Кого хотите зарегистрировать:" +
                                "\n1.Студент " +
                                "\n2.Аспирант ");

                            int m = Check.CheckInt();
                            if (m == 1)
                            {
                                Student st = new Student();
                                students.AddRange(new string[] { $"Студент {st.LastName} {st.Name} учиться в {st.Course}ом курсе." });                                
                                b1 = true;
                                break;
                            }

                            if (m == 2)
                            {
                                Aspirant asp = new Aspirant();
                                g_students.AddRange(new string[] { $"Аспирант {asp.LastName} {asp.Name} учиться в {asp.Course}ом курсе. Номер диссертации : {asp.Diss}" });
                                b1 = true;
                                break;
                            }

                        } while (b1 == false);
                        break;

                    case 2:
                        Console.WriteLine("Выберите 1 для информации о студентах и 2 для аспирантов.");
                        int i = Check.CheckInt();
                        switch (i)
                        {
                            case 1:
                                foreach (object stud in students)
                                {
                                    Console.WriteLine(stud);
                                }
                                break;
                            case 2:
                                foreach (object aspi in g_students)
                                {
                                    Console.WriteLine(aspi);
                                }
                                break;
                            default:
                                Console.WriteLine("Неправильный ввод.");
                                break;
                        }   
                        break;
                    case 3:
                        Console.WriteLine("Выберите 1 для удаление студентов и 2 для аспирантов.");
                        int f = Check.CheckInt();
                        switch (f)
                        {
                            case 1:
                                Console.WriteLine("Введите номер студента которого хотите удалить из списка");
                                int n = Check.CheckInt();
                                if (n >= 1 && n <= students.Count) { students.RemoveAt(n - 1); }
                                else { Console.WriteLine("Нет столько студентов."); }
                                break;
                            case 2:
                                Console.WriteLine("Введите номер аспиранта которого хотите удалить из списка");
                                int g = Check.CheckInt();
                                if (g >= 1 && g <= students.Count) { g_students.RemoveAt(g - 1); }
                                else { Console.WriteLine("Нет столько аспирантов."); }
                                break;
                            default:
                                Console.WriteLine("Неправильный ввод.");
                                break;
                        }                        
                        break;
                    case 4:
                        Console.WriteLine("Программа завершена.");
                        b = true;
                        break;
                }
            } while (b == false);
            Console.ReadKey();
        }
        }
    }

