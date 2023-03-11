namespace XndirN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone2 = new Phone();
            Console.WriteLine(phone2.number_print(095781236));
            Phone phone1 = new Phone("Tom");
            phone1.call_print();
            Answer a = new Answer("Yes");
            if (a.answer == "Yes")
            {
                Console.WriteLine("Call starts");
            }
            else
            {
                Console.WriteLine("Canceled");
            }
        }
    }
}