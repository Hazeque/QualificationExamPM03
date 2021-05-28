using System;
using System.Collections.Generic;
using System.Text;

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
                this.creator= value;
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
    }
    public static App[] Read(App[] Apps)
    {
        for (int i = 0; i < Apps.Length; i++)
        {
            Apps[i] = new App();
            Console.WriteLine("Введите наименование программы");
            Apps[i].Name = Console.ReadLine();
            Console.WriteLine("Введите производителя программы");
            Apps[i].Creator = Console.ReadLine();
            Console.WriteLine("Введите цену программы");
            Apps[i].Price = Convert.ToDouble(Console.ReadLine());
        }
        return Apps;
    }

      //for (int i = 0; i<Apps.Length; i++)
      //  {
      //      for (int j = 0; j<Apps.Length; j++)
      //      {

      //      }
      //  }
}

