using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// 주제 4. LinkedList
// 삽입 삭제가 빠르다.
// 인덱스를 사용해서 접근 할수 없다. -열거자로 사용

class Program
{
    public static void Main()
    {
        LinkedList<int> st = new LinkedList<int>();
        st.AddFirst(10);
        st.AddLast(20);

        st[0] = 10; // error. [] 연산 사용할수 없음.

        // 떨어진 메모리에 [] 있다면 사용자는 아래처럼 사용하려고 할겁니다.
        for (int i = 0; i < 10; i++)
        {
       //     st[i] = i; // 최악의 성능
        }
    }
}


