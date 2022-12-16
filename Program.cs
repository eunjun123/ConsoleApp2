using System;
using System.Collections.Generic;
using System.Text;

class Fahrenheit
{
    public static void Main()
    {
        double F; // 화씨온도 변수 선언
        double C; //섭씨온도 변수 선언

        Console.WriteLine("섭씨 온도를 입력하세요:");
        C = double.Parse(Console.ReadLine()); // 섭씨온도 입력받기

        F = 9.0 * C / 5.0 + 32.0; // 공식에 의해 섭씨온도를 화씨온도로 바꾸기
        Console.WriteLine("섭씨온도" + C + "도를 화씨 온도로 바꾸면" + F + "도입니다.");
    }
}