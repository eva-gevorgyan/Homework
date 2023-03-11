namespace XndirN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit("Apple", 5, 4.5);
            Unit unit1 = new Unit("Apple");
            Unit unit2 = new Unit("Grape");
            Unit unit3 = new Unit("Banana");
            Unit unit4 = new Unit("Mango");
            var name_list = new List<Unit>()
            {
                unit1, unit2, unit3, unit4
            };
            foreach (var n in name_list)
            {
                n.InStock();
            }
            Basket basket = new Basket("Tom", "Grape", 7, 2.2);
            basket.HelloUser();
            basket.PrintName();
            basket.PrintPrice();
            basket.PrintRating();
        }
    }
}