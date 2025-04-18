using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 스파르타던전
{
    internal class Shop
    {
        private bool[] isbuy = new bool[7];


        public void shopmenu(Player player)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("상점 - 아이템 구매");
                Console.WriteLine("필요한 아이템을 얻을 수 있읍니다.");
                Console.WriteLine();
                Console.WriteLine("[보유골드]");
                Console.WriteLine($"{player.Gold}G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine(" - 수련자 갑옷   | 방어력 +5  | 수련에 도움주는 갑옷임        | 1000 G");
                Console.WriteLine(" - 무쇠갑옷      | 방어력 +9  | 무쇠로 만든 튼튼갑옷임        | 구매완료");
                Console.WriteLine(" - 스르탄 갑옷   | 방어력 +15 | 스파르타의 전사들 전설갑옷임  | 3500 G");
                Console.WriteLine(" - 낡은 검       | 공격력 +2  | 낡은 검임                     | 600 G");
                Console.WriteLine(" - 청동 도끼     | 공격력 +5  | 청동 도끼임                   | 1500 G");
                Console.WriteLine(" - 스파르탄  창  | 공격력 +7  | 스파르탄의 전사가 사용한 창임 | 구매완료");


                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입하시오 \n>>");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        shopping(player);
                        break;
                    case "0":
                        return;                        
                    default:
                        Console.WriteLine("1,0 중 고르시오");
                        
                        break;
                }

            }
        }


        private void shopping(Player player)
        {
            
            Console.Clear();
            Console.WriteLine("상점 - 아이템 구매 하세요");
            Console.WriteLine();
            Console.WriteLine("[보유골드]");
            Console.WriteLine($"{player.Gold}G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("1 - 수련자 갑옷   | 방어력 +5  | 수련에 도움주는 갑옷임        | 1000 G");
            Console.WriteLine("2 - 무쇠갑옷      | 방어력 +9  | 무쇠로 만든 튼튼갑옷임        | 구매완료");
            Console.WriteLine("3 - 스르탄 갑옷   | 방어력 +15 | 스파르타의 전사들 전설갑옷임  | 3500 G");
            Console.WriteLine("4 - 낡은 검       | 공격력 +2  | 낡은 검임                     | 600 G");
            Console.WriteLine("5 - 청동 도끼     | 공격력 +5  | 청동 도끼임                   | 1500 G");
            Console.WriteLine("6 - 스파르탄  창  | 공격력 +7  | 스파르탄의 전사가 사용한 창임 | 구매완료");


            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입하시오 \n>>");

            string buy = Console.ReadLine();

            int itemNum;
            if (!int.TryParse(buy, out itemNum) || itemNum < 0 || itemNum > 6)
            {
                Console.WriteLine("잘못된 입력입니다.");
                return;
            }

            if (itemNum == 0) return;

            // 가격 테이블
            int[] itemprices = { 0, 1000, 2000, 3500, 600, 1500, 3000 };

            if (isbuy[itemNum])
            {
                Console.WriteLine("이미 구매한 아이템입니다.");
            }
            else if (player.Gold >= itemprices[itemNum])
            {
                player.Gold -= itemprices[itemNum];
                isbuy[itemNum] = true;
                Console.WriteLine("구매를 완료했습니다.");
            }
            else
            {
                Console.WriteLine("Gold 가 부족합니다.");
            }

            Console.WriteLine("\n계속하려면 아무 키나 누르세요");
            Console.ReadKey();
        }
                    }
            }

