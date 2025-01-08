using UnityEngine;

public class VariableTutoral : MonoBehaviour
{
    // 멤버 변수의 영역
    [SerializeField] private int health; // 0 초기화

    // Start 는 초기값 세팅 역할
    void Start()
    {
        // 무언가는 하겠다.
        // health 에 저장딘 값을 확인 하고싶다
        
        health = 300; //기획상의 설정값을 넣는다

        //Debug.Log() 는 콘솔창에 값을 출력하는 역할
        Debug.Log($"health :{health}");
    }

    // Update 는 실시간으로 변화하는 값을 반영한다
    void Update()
    {
        Debug.Log($"health : {health}");
    }
}
