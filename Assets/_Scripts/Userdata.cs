using UnityEngine;
class UserData : MonoBehaviour
{

    public string 이름 = "이름";

    public int 전투력;


    void Start()
    {
        Print();
        SayHello();
    }


    void Print()
    {
        Debug.Log($"내 이름은 <color=green>{이름}</color> 이고, 전투력은 <color=green>{전투력}</color> 입니다.");
    }
    void SayHello()
    {
        Debug.Log("안녕하세요");
    }
}    