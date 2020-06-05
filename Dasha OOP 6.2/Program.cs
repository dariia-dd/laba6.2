using System;
using System.IO;
namespace Dasha_OOP_6._2
{
    interface IDoctor
    {
        double Number();
        void Minimum();
        void Lenght();
    }


    abstract class Doctor:IDoctor
    {
        public string name;
        public int staz;
        abstract public double Number();
        abstract public void Minimum();
        abstract public void Lenght();

        public static void Add()
        {
            Console.WriteLine("Введiть данi");

            Console.Write("Прізвище: ");
            string str = Console.ReadLine();
            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", str);

            Console.Write("Фах: ");
            string URL1 = Console.ReadLine();
            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", URL1);

            Console.Write("День: ");
            string ddate = Console.ReadLine();

            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", ddate);

            Console.Write("Зміна: ");
            string host1 = Console.ReadLine();
            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", host1);

            Console.Write("Кількість відвідувачів: ");
            string down1 = Console.ReadLine();
            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", down1);

            Output.Write(Program.visit);

            Input.Key();

        }

        public static void Remove()
        {
            Console.Write("Про кого видалити дані: ");

            string name = Console.ReadLine();

            bool[] write = new bool[Program.visit.Length];

            for (int i = 0; i < Program.visit.Length; ++i)
            {
                if (Program.visit[i] != null)
                {
                    if (Program.visit[i].name == name)
                    {
                        Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", Program.visit[i].name, Program.visit[i].staz, Program.visit[i].date, Program.visit[i].coment, Program.visit[i].number);

                        Console.WriteLine("Видалити? (Y/N)\n");

                        var key = Console.ReadKey().Key;

                        if (key == ConsoleKey.Y)
                        {

                            Program.visit[i] = null;
                            Program.delete[i] = true;
                            Output.Write(Program.visit);



                        }
                        else
                        {
                            Program.delete[i] = false;
                        }
                    }
                }
            }
        }

        public static void Edit()
        {

            Console.WriteLine("Що ви хочете редагувати");
            string what = Console.ReadLine();
            switch (what)
            {
                case "name":
                    Console.WriteLine("Що саме");
                    string name1 = Console.ReadLine();
                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].name == name1)
                            {
                                Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", Program.visit[i].name, Program.visit[i].staz, Program.visit[i].date, Program.visit[i].coment, Program.visit[i].number);

                                Console.WriteLine("Введiть нову назву");

                                string str = Console.ReadLine();

                                Program.visit[i].name = str;

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;
                case "staz":
                    Console.WriteLine("Що саме");
                    string URL1 = Console.ReadLine();



                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].name == URL1)
                            {
                                Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", Program.visit[i].name, Program.visit[i].staz, Program.visit[i].date, Program.visit[i].coment, Program.visit[i].number);


                                Console.WriteLine("Введiть новий стаж");

                                string str = Console.ReadLine();

                                Program.visit[i].staz = int.Parse(str);

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;
                case "date":
                    Console.WriteLine("Що саме");
                    string name2 = Console.ReadLine();
                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].name == name2)
                            {
                                Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", Program.visit[i].name, Program.visit[i].staz, Program.visit[i].date, Program.visit[i].coment, Program.visit[i].number);


                                Console.WriteLine("Введiть нову дату");

                                string str = Console.ReadLine();

                                Program.visit[i].date = str;

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;
                case "coment":
                    Console.WriteLine("Що саме");
                    string name3 = Console.ReadLine();
                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].name == name3)
                            {
                                Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", Program.visit[i].name, Program.visit[i].staz, Program.visit[i].date, Program.visit[i].coment, Program.visit[i].number);

                                Console.WriteLine("Введiть новий коментар");

                                string str = Console.ReadLine();

                                Program.visit[i].coment = str;

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;

                case "number":
                    Console.WriteLine("Що саме");
                    string name4 = Console.ReadLine();
                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].name == name4)
                            {
                                Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", Program.visit[i].name, Program.visit[i].staz, Program.visit[i].date, Program.visit[i].coment, Program.visit[i].number);


                                Console.WriteLine("Введiть нову кількість");

                                int str = int.Parse(Console.ReadLine());

                                Program.visit[i].number = str;

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;

            }


        }




        private static void Save(Visiting m)
        {
            StreamWriter save = new StreamWriter("text.txt", true);

            save.WriteLine(m.name);
            save.WriteLine(m.staz);
            save.WriteLine(m.date);
            save.WriteLine(m.coment);
            save.WriteLine(m.number);

            save.Close();
        }

        public static void Parse(string[] elements, bool save)
        {
            int counter = 0;

            while (Program.visit[counter] != null)
            {
                ++counter;
            }

            for (int i = 0; i < elements.Length; i += 5)
            {
                Program.visit[counter + i / 5] = new Visiting(elements[i], int.Parse(elements[i + 1]), elements[i + 2], elements[i + 3], int.Parse(elements[i + 4]));

                if (save)
                {
                    Save(Program.visit[counter + i / 5]);
                }
            }
        }
        public static string[] Read()
        {
            StreamReader fromFile = new StreamReader("text.txt");

            return fromFile.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        }


    }
    class Visiting : Doctor
    {
        public string date;
        public string coment;
        public int number;
        public Visiting(string name, int staz, string date, string coment, int number)
        {
            this.name = name;
            this.staz = staz;
            this.date = date;
            this.coment = coment;
            this.number = number;
        }
        public override double Number()
        {
            double n = 0;
            for (int i = 0; i < Program.visit.Length; i++)
            {
                if (Program.visit[i] != null)
                {
                    n += Program.visit[i].number;
                }
            }
            Console.WriteLine("Середня кількість відвідувачів: {0}", n / 5);
            return n;
        }
        public override void Minimum()
        {
            int min = Program.visit[0].number;
            int n = 0;
            for (int i = 0; i < Program.visit.Length; i++)
            {
                if (Program.visit[i] != null)
                {
                    if (Program.visit[i].number < min)
                    {
                        min = Program.visit[i].number;
                        n = i;
                    }
                }
            }
            Console.WriteLine("прийом з мінімальною кількістю відвідувачів:");
            Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", Program.visit[n].name, Program.visit[n].staz, Program.visit[n].date, Program.visit[n].coment, Program.visit[n].number);

        }
        public override void Lenght()
        {
            int max = Program.visit[0].coment.Length;
            int index = 0;
            for (int i = 0; i < Program.visit.Length; i++)
            {
                if (Program.visit[i] != null)
                {
                    if (Program.visit[i].coment.Length > max)
                    {
                        max = Program.visit[i].coment.Length;
                        index = i;
                    }

                }


            }
            Console.WriteLine("найдовший коментар: {0}", Program.visit[index].coment);
        }
    }

    class Output
    {
        public static void Write(Visiting[] v)
        {
            Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", "Прізвище", "Cтаж", "День", "коментар", "кількість відвідувачів");

            for (int i = 0; i < v.Length; ++i)
            {
                if (v[i] != null)
                {

                    Console.WriteLine("{0,-20} {1, -20} {2, -20} {3, -20} {4, -15}", Program.visit[i].name, Program.visit[i].staz, Program.visit[i].date, Program.visit[i].coment, Program.visit[i].number);
                }
            }
        }
    }
    class Input
    {


        public static void Key()
        {
            Doctor.Parse(Read(), false);

            Console.WriteLine("Додавання записiв: +");
            Console.WriteLine("Редагування записiв: E");
            Console.WriteLine("Знищення записiв: -");
            Console.WriteLine("Середня кількість відвідувачів: K");
            Console.WriteLine("прийом з мінімальною кількістю відвідувачів: F");
            Console.WriteLine("Найдовший коментар: S");
            Console.WriteLine("Виведення записiв: Enter");

            Console.WriteLine("Вихiд: Esc");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.OemPlus:
                    Console.WriteLine();
                    Doctor.Add();
                    break;

                case ConsoleKey.E:
                    Console.WriteLine();
                    Doctor.Edit();
                    break;

                case ConsoleKey.OemMinus:
                    Console.WriteLine();
                    Doctor.Remove();
                    break;

                case ConsoleKey.Enter:
                    Console.WriteLine();
                    Output.Write(Program.visit);
                    Key();
                    break;
                case ConsoleKey.F:
                    Console.WriteLine();
                    Program.visit[0].Minimum();
                    break;
                case ConsoleKey.S:
                    Console.WriteLine();
                    Program.visit[0].Lenght();
                    break;
                case ConsoleKey.K:
                    Console.WriteLine();
                    Program.visit[0].Number();
                    break;



                case ConsoleKey.Escape:
                    return;
            }
        }
        public static string[] Read()
        {
            StreamReader fromFile = new StreamReader("text.txt");

            return fromFile.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        }
    }



    class Program
    {
        public static Visiting[] visit = new Visiting[1000000];
        public static bool[] delete = new bool[1000000];
        static void Main(string[] args)
        {
            Input.Key();
        }
    }
}

