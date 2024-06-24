using System;

// int n = Console.Read();	// 입력 대기
							// enter 를 입력해야 
							// 입력완료

Console.Write("press any key >> ");

//ConsoleKeyInfo cki = Console.ReadKey();
ConsoleKeyInfo cki = Console.ReadKey(true);

Console.WriteLine(cki.KeyChar); 
