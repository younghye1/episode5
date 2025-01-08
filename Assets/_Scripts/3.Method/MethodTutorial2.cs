using UnityEngine;

public class MethodTutorial2 : MonoBehaviour
{


    public MethodTutorial mt;
    public int A,B;

    void Start()
    {
        // 다른 곳에서 선언한 메소드를 출력한다
        int temp = mt.Add(A,B);
        Debug.Log(temp);
    }

}
