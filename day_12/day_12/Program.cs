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
            Console.WriteLine("Фамилия студента");
            LastName = Check.CheckString();
            Console.WriteLine("Имя студента :");
            Name = Check.CheckString();
            Console.WriteLine("Курс :");
            Course = Check.CheckInt();
        }
        public abstract void InputData();
    }

    
        class Student : Person
        {
            
            public Student() : base()
            {                                
            }
            public override void InputData()
            {
                Console.WriteLine($"{LastName} {Name} учиться в {Course}ом курсе.");

            }

        }
    class Aspirant : Person
        {
            int Diss { get; set; }
            public Aspirant()
                : base( )
            {
                Console.WriteLine("Номер диссертации :");
                this.Diss = Check.CheckInt();
            }
            
            public override void InputData()
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
                Console.WriteLine("1.Регистрация студентов :" +
                    "\n2.Выход :");

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
                                    st.InputData();
                                    b1 = true;
                                    break;
                                }

                                if (m == 2)
                                {
                                    Aspirant asp = new Aspirant();
                                    asp.InputData();
                                    b1 = true;
                                    break;
                                }

                            } while (b1 == false);
                            break;
                        
                        case 2:
                            Console.WriteLine("Программа завершена.");
                            b = true;
                            break;
                    }
                } while (b == false);
            }
        }
    }

