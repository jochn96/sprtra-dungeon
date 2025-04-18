using System.Reflection.Emit;

namespace 스파르타던전
{
    internal class Program
    {
        static Player player = new Player();
        static Inven inven = new Inven();
        static Shop shop = new Shop();  
        static void Main(string[] args)
        {
           
            while (true)
            {
                ShowMainMenu();
                string input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                        player.Showstats();  
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case "2":
                        //Console.WriteLine("인벤토리를 엽니다");
                        inven.Showinven();
                        Console.WriteLine();
                        Console.ReadLine();
                        break;


                     case "3":
                        shop.shopmenu(player);
                         break;
                     default:
                         Console.WriteLine("1,2,3,중 고르시오");
                         Console.ReadKey();
                        break;                        
                        }


                }
            }
            static void ShowMainMenu()
            {
                Console.Clear();
                Console.WriteLine("스파르타 던전에 오신걸 환영합니다");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있다");
                Console.WriteLine();
                Console.WriteLine("1.상태 보기");
                Console.WriteLine("2.인벤토리");
                Console.WriteLine("3.상점");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입하시오 \n>>");
                Console.WriteLine();
            }



        }
    }

