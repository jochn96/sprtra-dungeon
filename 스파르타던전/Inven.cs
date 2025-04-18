using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 스파르타던전
{
    public class Inven

    {
        static Player player = new Player();

        public void Showinven()
        {
            while (true)
            {
                {
                    Console.Clear();
                    Console.WriteLine("인벤토리");
                    Console.WriteLine("보유 중인 아이템을 관리할 수 있읍니다");
                    Console.WriteLine();
                    Console.WriteLine("[아이템 목록]");
                    Console.WriteLine();
                    Console.WriteLine("1 장착 관리");
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine();
                    Console.Write("원하시는 행동을 입하시오 \n>>");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            ShowEqM();
                            break;
                            //EqM == 장착관리메뉴

                        case "0":
                            return;
                        default:
                            Console.WriteLine("잘못된 입력입니다. 다시 입력하세요.");
                            Console.WriteLine("계속하려면 아무 키나 누르세요...");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }


        private void ShowEqM()
        { 
            
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있읍니다.");

            Console.WriteLine("[아이템 목록]");
            
            string iteam = Console.ReadLine();
            switch (iteam)
            {

            }

        }







    }
}