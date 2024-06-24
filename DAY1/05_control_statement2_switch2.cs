using System;

int num = 1;

switch (num)
{
    // 아래 처럼 만드는 것은 허용됩니다.
    case 0:
    case 1:
        Console.WriteLine("1");
        break;

    case 2:
        Console.WriteLine("1");
        break;
    case 3:
        Console.WriteLine("1");
        break;


    default:
        Console.WriteLine("other");
        break;
}