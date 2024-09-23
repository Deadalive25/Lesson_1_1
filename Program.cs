namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string middle_name = Console.ReadLine();
            Console.WriteLine(surname + " " + name + " " + middle_name);
        }
    }
}
