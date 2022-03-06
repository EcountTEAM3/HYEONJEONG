using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto_0304
{ /*1. 1~45까지의 난수를 발생시켜 6개의 배열에 담으세요
lotto[0] = 44, lotto[1] = 1....lotto[5] = 33
* 2.배열에 담긴 6개의 배열값은 중복값이 나오면 안되요(중복값 검증 :별찍기 비슷)
*3. 배열에 있는 6개의 값은 낮은 순으로 정렬 시키세요(정렬 : 자리바꿈)
*4. 위 결과를 담고 있는 배열을 출력하세요(화면 출력)*/

    class lottoprac
    {

        static void Main(string[] args)
        {
            int[] lotto = new int[6];
            int temp;
            Random ran = new Random();
            

            for (int i =0; i<lotto.Length; i++)
            {
                int lottonum = ran.Next(1, 45);
                lotto[i] = lottonum; // ?!?!
                for(int j=0; j<i; j++)
                {
                    if(lotto[i] == lotto[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            for(int i =0; i<lotto.Length; i++)
            {
                for(int j =i+1; j<lotto.Length; j++)
                {
                    if(lotto[i] > lotto[j])
                    {
                        temp = lotto[i];
                        lotto[i] = lotto[j];
                        lotto[j] = temp;
                    }
                }
            }
            for(int i=0; i<lotto.Length; i++)
            {
                Console.WriteLine("로또번호:{0}",lotto[i]);
            }
            Console.WriteLine();
        }
    }
}
