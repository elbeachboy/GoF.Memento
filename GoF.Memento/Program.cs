using System;

namespace GoF.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesLineItem = new SalesLineItem();
            salesLineItem.Name = "Apple Iphone 12 mini";
            salesLineItem.Price = "1000";
            salesLineItem.Amount = 2;

            //Werte speichern
            var sales = new Sales();
            sales.Memento = salesLineItem.SaveMemento();

            //Werte verändern
            salesLineItem.Name = "Huawei Mate 20 Pro";
            salesLineItem.Price = "500";
            salesLineItem.Amount = 20;

            //Werte von vorher wiederherstellen
            salesLineItem.RestoreMemento(sales.Memento);

            Console.ReadKey();

        }
    }
}
