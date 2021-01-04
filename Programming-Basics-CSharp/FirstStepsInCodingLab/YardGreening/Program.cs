using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read Кв. метри, които ще бъдат озеленени
            double m = double.Parse(Console.ReadLine());

            //Цената на един кв. м. е 7.61лв със ДДС
            //18% отстъпка от крайната цена
            double FinalPriceWithoutDiscount = m * 7.61;
            double Discount = 0.18 * FinalPriceWithoutDiscount;
            double FinalPrice = FinalPriceWithoutDiscount - Discount;

            Console.WriteLine($"The final price is: {FinalPrice} lv.");
            Console.WriteLine($"The discount is: { Discount} lv.");
        }
    }
}
