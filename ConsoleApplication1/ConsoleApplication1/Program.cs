using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*
     Интерфейс Icomparable обеспечивает поведение объектов позволяющее выполнять их сравнение
     Мы должны указать правила сравнения двух объектов, если объекты равны то необходимо вернуть "0",
     "1" если наш объект больше предыдущего и "-1" если меньше
     этот интерфейс используется для сортировки объектов
          */


    class Item
    {

        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return Name + " " + Price + " UA " + Quantity + " HT";
        }
    }
    class Items : IEnumerable, IEnumerator
    {
        int index;
        Item[] items = new Item[3];
        public Items()
        {
            items[0] = new Item("Mathematic 10-11", 120.0, 1);
            items[1] = new Item("С# 5.0", 420.0, 1);
            items[2] = new Item("MS SQL Server", 480.0, 1);
        }
        public object Current
        {
            get
            {
                return items[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public bool MoveNext()
        {
            if ((index + 1) < items.Length)
            {
                ++index;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = 0;
        }
    }
    public class Tester
    {
        public static void Main()
        {
            Items its = new Items();
            //foreach (var item in its)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(its.Current);
            while (its.MoveNext())
            {
                Console.WriteLine(its.Current);
            }

            its.Reset();
            Console.WriteLine(its.Current);

        }
    }
    static void Main(string[] args)
        {

        }
    }
}
