using UnityEngine;

public class ClassCalculator : MonoBehaviour
{
     public int num1;
     public int num2;
     


     void Start()
     {
        Debug.Log($"더하기= {Method1(num1,num2)}");
        Debug.Log($"빼기= {Method2(num1,num2)} ");
        Debug.Log($"곱하기= {Method3(num1,num2)} ");
        Debug.Log($"나누기= {Method4(num1,num2)} ");
     }

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
