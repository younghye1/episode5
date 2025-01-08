//네임스페이스 (NameSpace)
using UnityEngine;

//클래스 (Class)
public class ClassCalculator : MonoBehaviour
{
    //멤버 변수 (Variables)
     public int num1;
     public int num2;
     

    // 많이 쓰이거나, 상속받은, 공용 영역 (Public Area)
    // 메소드, 함수, 서브루틴 (Method , Function)
     void Start()
     {
        //메소드를 이용해서 계산
        Debug.Log($"더하기= {Method1(num1,num2)}");
        Debug.Log($"빼기= {Method2(num1,num2)} ");
        Debug.Log($"곱하기= {Method3(num1,num2)} ");
        Debug.Log($"나누기= {Method4(num1,num2)} ");
     }


     // Y= f(x, y, z)
     // 메소드를 선언 (Method Declare)

     // 개인적인 영역 (Private Area)
     int Method1(int num1 , int num2)
    {
         return num1 + num2;
    }

    int Method2(int num1 , int num2)
    {
        return num1-num2;
    }
    
    int Method3(int num1 , int num2)
    {
        return num1*num2;
    }

    int Method4(int num1 , int num2)
    {
        return num1/num2;
    }

}
