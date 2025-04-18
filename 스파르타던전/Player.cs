using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace 스파르타던전
{
     public class Player
    {

        public int Level { get; set; } = 1;
        public string Name { get; set; } = "JO";
        public string Job { get; set; } = "전사";
        public int Atk { get; set; } = 10;
        public int Def { get; set; } = 5;
        public int Hp { get; set; } = 100;
        public int Gold { get; set; } = 1000;


        public void Showstats()
        {
            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine($"Lv. {Level}");
            Console.WriteLine($"{Name} {Job}");
            Console.WriteLine($"공격력 : {Atk}");
            Console.WriteLine($"방어력 : {Def}");
            Console.WriteLine($"체력   : {Hp}");
            Console.WriteLine($"Gold   : {Gold}");
            Console.WriteLine();
            Console.WriteLine("아무키 입력하여 메인메뉴로 돌아가기");
            Console.WriteLine();
            Console.Write("입력하샘 \n>>");

        }
    }


}
