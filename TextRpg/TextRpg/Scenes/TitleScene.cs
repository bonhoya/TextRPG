using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg.Scenes
{
    public class TitleScene : Scene
    {
        

        public override void Render()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*            TEXT RPG           *");
            Console.WriteLine("*********************************");
            Console.WriteLine();
        }

        public override void Result() { }

        public override void Choice()
        {
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임 종료");
        }

        public override void Wait() { }

        public override void Next()
        {
            // TODO : 다음 씬으로 전환 구현 필요
            // TODO주석을 사용하면 보기-작업목록에서 확인이 가능

            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Town");
                    break;
            }

        }

    }
}
