using System;

namespace Bai2
{
    internal class OrderDetail
    {
        public string Name { get; set; }
        public long Price { set; get; }
        public int Count { set; get; }
        public long Total { set; get; }

        public OrderDetail()
        {

        }
        public OrderDetail(string name, long price, int count, long total)
        {
            Name = name;
            Price = price;
            Count = count;
            Total = total;
        }
        public void Show()

        {
            Console.WriteLine("Name : ", Name);
            Console.WriteLine("Price : ", Price);
            Console.WriteLine("Count : ", Count);
            Console.WriteLine("Total : ", Total);
        }
        public void CalculatorTotal()
        {
            Total = Price * Count;
        }
    }
}