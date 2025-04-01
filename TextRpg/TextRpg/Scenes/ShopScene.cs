using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg.Scenes
{
    public class ShopScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("\"어서오세요\"");
            Console.WriteLine("\"좋은 물건 많습니다~\"");
            Console.WriteLine("상점에는 다양한 물건들이 늘어져 있다.");
            Console.WriteLine("어떤 물건을 구매하시겠습니까?");
        }
        public override void Choice()
        {
         
            Console.WriteLine("1. 누가봐도 수상한 저주받은 것 같은 구슬을 산다.");
            Console.WriteLine("2. 상인에게 들려오는 소문이 있는지 묻는다.");
            Console.WriteLine("3. 상인을 위협하고 돈을 갈취 시도한다.");
            Console.WriteLine("4. 마을로 돌아갑니다.");
        }

        

       

        public override void Result()
        {
           switch(input)
            {
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 상인을 위협하고 돈을 내놓으라 소리쳤습니다...");
                    Console.WriteLine("하지만 상인이 당신보다 더 강했습니다.");
                    Console.WriteLine("당신은 상인에게 공격을 받아 나가 떨어졌습니다.");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("당신은 마을로 돌아갑니다.");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다. 다시 입력해주세요.");
                    break;

            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하시려면 아무키나 눌러주세요...");
            Console.WriteLine();
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D4:
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D3:
                    Game.GameOver("함부로 누군가를 공격하지 맙시다...");
                    break;

            }
        }
    }
}
