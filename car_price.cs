using System;

namespace VehiclePriceDemo
{
    // 定義 IPrice 介面
    public interface IPrice
    {
        decimal GetPrice(); // 回傳車輛價格
    }

    // 定義 Car 類別並實作 IPrice 介面
    public class Car : IPrice
    {
        public string Make { get; set; }         // 車廠
        public string Model { get; set; }        // 車型
        public decimal Price { get; set; }       // 價格

        // 建構子
        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        // 實作 IPrice 的方法
        public decimal GetPrice()
        {
            return Price;
        }

        // 顯示車輛資訊
        public void DisplayInfo()
        {
            Console.WriteLine($"品牌：{Make}，型號：{Model}，價格：{GetPrice():C}");
        }
    }

    // 主程式測試
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Car myCar = new Car("Toyota", "Camry", 850000);
            myCar.DisplayInfo(); // 顯示品牌、型號與價格
        }
    }
}
