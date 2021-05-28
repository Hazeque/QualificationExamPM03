using System;
using System.IO;

namespace QualExam
{
    class App
    {
        string name;
        string creator;
        double price;

        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
            }
        }
        public string Creator
        {
            get => this.creator;
            set
            {
                this.creator = value;
            }
        }
        public double Price
        {
            get => this.price;
            set
            {
                this.price = value;
            }
        }

        public static App[] Read(App[] Apps)
        {
            for (int i = 0; i < Apps.Length; i++)
            {
                Apps[i] = new App();
                Console.WriteLine("Введите наименование программы: ");
                Apps[i].Name = Console.ReadLine();
                Console.WriteLine("Введите производителя программы: ");
                Apps[i].Creator = Console.ReadLine();
                Console.WriteLine("Введите цену программы: ");
                Apps[i].Price = Convert.ToDouble(Console.ReadLine());
            }
            return Apps;
        }

        public static bool operator > (App First, App Second)
        {
            if (string.Compare(First.Creator, Second.Creator) == -1) 
                return true;
            else if (string.Compare(First.Creator, Second.Creator) == 1) 
                return false;
            else if (First.Price > Second.Price) 
                return true;
            else 
                return false;
        }

        public static bool operator < (App First, App Second)
        {
            if (string.Compare(First.Creator, Second.Creator) == -1)
                return true;
            else if (string.Compare(First.Creator, Second.Creator) == 1) 
                return false;
            else if (First.Price > Second.Price) 
                return true;
            else 
                return false;
        }

        public static App[] Sort(App[] Apps)
        {
            for (int i = 0; i < Apps.Length; i++)
            {
                for (int j = 0; j < Apps.Length; j++)
                {
                    if (Apps[i] > Apps[j])
                    {
                        App buffer = Apps[i];
                        Apps[i] = Apps[j];
                        Apps[j] = buffer;
                    }
                }
            }
            return Apps;
        }

        public static void WriteMas(App[] Apps)
        {
            
            using (StreamWriter sw = new StreamWriter(@"Apps.txt"))
            {
                foreach (App a in Apps)
                {
                    sw.WriteLine($"Наименование: {a.Name}\nПроизводитель:{a.Creator}\nЦена:{a.Price}\n\n\n");
                }
            }
        }
    }
}

