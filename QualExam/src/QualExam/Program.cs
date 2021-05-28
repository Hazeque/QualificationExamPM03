using System;

namespace QualExam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int quantity = 0;
                Console.Write("Введите количество элементов в массиве: "); quantity = Convert.ToInt32(Console.ReadLine());
                App[] Apps = new App[quantity];
                App.Read(Apps);
                App.Sort(Apps);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
