using UnityEngine;


public class VariableType : MonoBehaviour
{
    [Header("정수타입")]
    // int : -21억4천만 ~ 21억4천만 , 크기: 4 byte
    public int intType = 0;

    // long : -9223372036854775808 ~ 9223372036854775808 , 크기: 8 byte
    public long longType = 0;

    // short : -32768 ~ 32767 , 크기: 2 byte
    public short shortType = 0;
    
    // byte : 0 ~ 255 , 1 byte (R,G,B,A) 4byte
    public byte bytetype = 0;

    
    [Header("실수타입")]
    //flot : -9999999 ~ 9999999 , 크기: 4 byte
    public float floatType =0.0f;

    //double 크기: 8 byte
    public double doubleType = 0.0;

    //decimal 크기: 128 byte
    public decimal decimalType = 0;

    [Header("문자타입")]
    public string stringType;

    [Header("부울타입")]
    // 값: True, False / 크기: 1byte
    public bool boolType;


    void Start()
    {
        //무언가의 크기
        Debug.Log($"int : {sizeof(int)} , long : {sizeof(long)} , short : {sizeof(short)} float : {sizeof(float)} bool: {sizeof(bool)}");    

        floatType = 3.14152f;
        Debug.Log($"소수점{floatType}");
        //3.141592f; 끝에 f를 넣던가 (float)숫자로 앞에 괄호 플롯을 넣던가

        doubleType = 3.14;
        //더블 소수점 뒤엔 f를 넣지 않는다

        intType = (int)3.14f;
        Debug.Log($"intType = {intType}");
        //앞에 괄호 인트를 넣은 소수점은 정수만 나간다

        floatType = (float)intType;
        Debug.Log($"floatType = {floatType}");


        string result = $"문자 내용은 {stringType}입니다";
        string result2 = $"문자의 길이는{stringType.Length} 입니다.";
        string result3 = $"ㅁㄴㅇㄹㄴㄹㅇㅁ";

        Debug.Log(result + result2 + result3);
        //문장 합칠 수 있다
        Debug.Log("안녕하세요");
        //역슬래시 따옴표x2 문장 쓰면 따옴표까지 반영된다


        //부울의 크기
         string boolsize=$"bool Size= {sizeof(bool)}";
        //부울의 값
        string boolvalue=$"bool value = {sizeof(bool)}";

        Debug.Log($"{boolType}");


    }
    
    void Update()
    {
        //Debug.Log($"정수(Integer) = {intType}");
        //Debug.Log($"롱타입(Long) ={longType} ");
        //Debug.Log($"숏타입(short) ={shortType} ");
        //Debug.Log($"바이트타입(byte) ={bytetype} ");
        //Debug.Log($"플롯타입(float) ={floatType} ");
    }
}

