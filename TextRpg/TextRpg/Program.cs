namespace TextRpg
{
    // 강사님 화면 보고 모방하여 따라하기

    // <간이 기획>
    // 상황 설명이 주어지고
    // 선태지를 제시
    // 선택지 입력을 대기
    // 선택한 선택지에 따라서 결과를 출력
    // 다음으로 넘어가기 대기(아무키나 누르세요)
    // 다음 상황으로 전환
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.Start();
            Game.Run();
            Game.End();
        }
    }
}
