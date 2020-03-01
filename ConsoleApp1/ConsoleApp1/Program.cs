using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool BoolVar;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0} {1}",3.14f, 12);
            Console.WriteLine("{0} + {1} = {2} ", 1, 2, 1+2);
            Console.WriteLine ("{0:C} {1:P} {0:X}", 123, 123.45);
            //===========================================================================


            //3-1 클래스의 정적 변수 bool형의 기본값과 지역 bool 변수 값을 출력해 보자

            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}", BoolVar, LocalBoolVar);
            //출력값 : False  True

            //===========================================================================

            char Mun = '7'; //문자상수값 : 55
            int Num = Mun; //암시적 형 변환
            Num = Mun + 1;
            Console.WriteLine("Mun = {0} 문자상수값 = {1} 유니코드 문자 = {2}", (int)Mun, Num, (char)Num);
            /*
            Mun = (char)Num;
            Console.WriteLine(Mun);
            */

            //===========================================================================

            //byte 형 두 값을 더하고 그 값을 int 형 변수에 대입하여 출력해 보자
            int result;
            byte x = 1, y = 2;
            result = x + y;
            Console.WriteLine(result);

            //===========================================================================
            //short 형의 유효 범위 값을 출력해보자
            // short의 유효범위 : -32768 ~ 32767
            //public const short MinValue
            //public const short MaxValue
            Console.WriteLine("{0} ~ {1}", short.MinValue, short.MaxValue);
            //결과값 : -32768 ~ 32767

            //===========================================================================
            //두 문자열을 합친 후에 합친 문자열과 다섯번째 문자를 출력해 보자
            string str1 = "Hello ";
            string str2 = "World!";
            string str3 = str1+str2;
            string str4 = "program" + "mining";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]);

            if (str3 == "Hello World!") {
                Console.WriteLine("같음");
            }
            else {
                Console.WriteLine("다름");
            }
            //===========================================================================
            //문자열의 문자 개수를 Length로 확인해 보자.
            string str5 = "Hello World!";
            Console.WriteLine("문자 개수 : {0}", str5.Length);

            //===========================================================================
            //백스페이스가 있는 문자열을 출력해 보자
            string str6 = "C:\\temp\\test.txt";
            string str7 = @"C:\temp\test.txt";
            Console.WriteLine("{0} {1}", str6, str7);
            //출력값 (str6, str7) 이 동일함을 확인 가능

            //===========================================================================
            /*
             var 를 사용할 수 없는 예
                (1) null 값 초기화 , 매개변수로는 사용 못 함
                (2) var 는 지역변수로만 사용 클래스 멤버로는 사용 못함
                (3) 연속적으로 초기화 하는 경우
                    var m = 10, n = 20;
             */
            // var 형 변수에 데이터가 분명한 값으로 선언과 초기화를 한 
            // 후에 두 값을 더한 결과를 출력해 보자
            var value1 = 3.14f;
            float value2 = 10.0f;
            float sum = value1 + value2;
            Console.WriteLine("{0}, {1:f1}, {2}", value1, value2, sum);
            //출력값 : 3.14, 10.0, 13.14

            //===========================================================================

            //nullable형 : null 을 허용하지 않는 데이터형 이 null 값을 허용
            //nullable 형을 선언하고 판독해 보자
            int? Number = null;
            if (Number.HasValue)
                Console.WriteLine("올바른 값");
            else
                Console.WriteLine("Null 값");

            Console.WriteLine("null : {0}", Number);
            /* 출력값 :
             
             Null 값
             null :
             */

        }
    }
}
