using System;

class Program
{
    // 定義一個委派：接受 double，回傳 double
    delegate double ConvertToInches(double value);

    // 方法：英尺轉英吋
    static double FeetToInches(double feet)
    {
        return feet * 12;
    }

    // 方法：英瑪轉英吋
    static double YardToInches(double yards)
    {
        return yards * 3 * 12; // 1 yard = 3 feet = 36 inches
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("請輸入數值：");
        double inputValue = double.Parse(Console.ReadLine());

        Console.WriteLine("請選擇單位要轉換：");
        Console.WriteLine("1. 英尺 轉 英吋");
        Console.WriteLine("2. 英瑪 轉 英吋");
        string choice = Console.ReadLine();

        // 宣告委派
        ConvertToInches converter;

        // 根據選項指派對應方法
        if (choice == "1")
        {
            converter = FeetToInches;
        }
        else if (choice == "2")
        {
            converter = YardToInches;
        }
        else
        {
            Console.WriteLine("無效的選項");
            return;
        }

        // 執行轉換
        double result = converter(inputValue);
        Console.WriteLine($"轉換結果為：{result} 英吋");
    }
}
