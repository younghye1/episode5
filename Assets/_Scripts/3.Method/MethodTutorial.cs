using UnityEngine;

public class MethodTutorial : MonoBehaviour
{

   public int A, B;

    private void Start()
    {
        Method1();


        //int addresult;

        // Add 메소드 호출
       //addresult = Add(A, B);
       //Debug.Log(addresult);
    }

    int volume = 10;
    public int volume2;


    // 메소드 선언
    private void Method1(/* input, 파라미터*/)
    {
        // (지역) 변수
        Debug.Log(volume);
    }



    // Add 메소드를 만들고, MethodTutorial2 멤버변수 A,B , 값 로그를 출력하기
    //메소드 선언
    public int Add(int a, int b)
    {
        return a + b;
    }
}
