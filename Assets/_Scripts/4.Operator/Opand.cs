using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Opand : MonoBehaviour
{
    [Header("입력창")]
    public bool A;
    public bool B;   
    public int nC;


    [Header("결과창")]
    [ReadOnly] public bool opSame;
    [ReadOnly] public bool opDiff;
    [ReadOnly] public bool opGreater;


    void Update()
    {
        
       bool isSame = A == B;
       opSame = isSame;

       bool isDiff = A != B;
       opDiff = isDiff;

        //nC가 10보다 큰가?
        bool isGreater = nC > 10; 
        opGreater=isGreater;

        Debug.Log( nC <= 10);

    }


}
