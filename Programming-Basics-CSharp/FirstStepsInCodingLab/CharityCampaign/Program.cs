using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //броят на дните, в които тече кампанията
            int days = int.Parse(Console.ReadLine());
            //броя на сладкарите, които ще се включат
            int confectioner = int.Parse(Console.ReadLine());
            //количествата, които ще бъдат приготвени от един сладкар за един ден
            int cake = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            //Сума събрана от цялата кампания
            double totalMoney = days * confectioner * (cake * 45 + waffles * 5.80 + pancakes * 3.20);
            //Сума след покриване на разходите
            double money = totalMoney - (totalMoney / 8);

            Console.WriteLine(money);
        }
    }
}
