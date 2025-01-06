using System;
using UnityEngine;

public class HelloMethod : MonoBehaviour
{
    


    void Start()
    {
        // Method1(1);
        // Method1(2);
        // Method1(3);
        // Method1(4);
        
        // Method2("홍길동");

        //Debug.Log($"{Method3(2,3)}");
        Debug.Log($"공격력 {Method1(99)} 입니다");

    }

    int Method1(int attack)
    {
        return attack+10;
    }

    void Method2(string myName)
    {
        Debug.Log($"내 이름은 {myName} 입니다");
    }

    int Method3(int damage1 , int damage2)
    {

        return damage1 + damage2;
    }


}
