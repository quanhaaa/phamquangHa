﻿using System;

namespace BaiTap
{
    class TestCsharp
    {
        public static void Main()
        {
            int number1, number2, number3, number4;

            Console.Write("Nhap so thu nhat: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu tu: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            int result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("Gia tri trung binh cua {0} , {1} , {2} , {3} la: {4} ",
            number1, number2, number3, number4, result);
            Console.ReadKey();
        }
    }
}