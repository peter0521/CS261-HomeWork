using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    /*
    流程:
    1.建立物件
    Game game = new Game();

    2.產生答案
    game.answer = game.CreateNumbers();

    3.產生USER答案
    List<int> userAnswer = game.CreateNumbers();

    4.輸出結果
    Console.WriteLine(game.GetResult(userAnswer));
    */

    public class Game
    {
        //答案
        public List<int> answer = new List<int>();

        //亂數
        private Random random = new Random();

        //取得數字
        public List<int> CreateNumbers()
        {
            List<int> numbers = new List<int>();

            do
            {
                int number = random.Next(1, 10);
                if (!this.IsInAnswer(number, numbers))
                    numbers.Add(number);
            } while (numbers.Count < 4);
            return numbers;
        }

        //檢查是否重複
        private bool IsInAnswer(int number, List<int> numbers)
        {
            for (int index = 0; index < numbers.Count; index++)
            {
                if (number == numbers[index])
                {
                    return true;
                }
            }
            return false;
        }

        //取回結果
        public int[] GetResult(List<int> userAnswer)
        {
            int[] Count = new int[] { 0, 0 };

            for (int userAnswerIndex = 0; userAnswerIndex < 4; userAnswerIndex++)
            {
                for (int answerIndex = 0; answerIndex < 4; answerIndex++)
                {
                    if (userAnswer[userAnswerIndex] == this.answer[answerIndex])
                    {
                        if (userAnswerIndex == answerIndex)
                        {
                            Count[0]++;
                        }
                        else
                        {
                            Count[1]++;
                        }
                    }
                }
            }
            //Count[2] = this.ConvertNumbersToString(this.answer);
            return Count;
        }

        /*取回結果原始版本
        public string GetResult(List<int> userAnswer)
        {
            int aCount = 0;
            int bCount = 0;
            string result = "";

            for (int userAnswerIndex = 0; userAnswerIndex < 4; userAnswerIndex++)
            {
                for (int answerIndex = 0; answerIndex < 4; answerIndex++)
                {
                    if (userAnswer[userAnswerIndex] == this.answer[answerIndex])
                    {
                        if (userAnswerIndex == answerIndex)
                            aCount++;
                        else
                            bCount++;
                    }
                }
            }
            result += "Game Answer:" + this.ConvertNumbersToString(this.answer) + "\n";
            result += "User Answer:" + this.ConvertNumbersToString(userAnswer) + "\n";
            return result + string.Format("\n{0}A{1}B", aCount, bCount);
        }
        */

        //轉成字串
        public string ConvertNumbersToString(List<int> numbers)
        {
            string result = "";
            for (int index = 0; index < numbers.Count; index++)
                result += numbers[index].ToString();

            return result;
        }
    }
}