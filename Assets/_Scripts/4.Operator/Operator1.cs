using UnityEngine;
public class Operator1 : MonoBehaviour
{
    // 연산자 (Operator)

    public float A;
    public float B;
    public float C;

    public string TA;
    public string TB;  

    public bool ba;
    public bool bb;    
    public bool bc;  



    public float weight; // 몸무게 입력
    public float height; // 키 입력

   

    [Header("연산자 결과")]
    [ReadOnly] public bool andOP; //AND연산 결과
    [ReadOnly] public bool orOP; //OR연산 결과
    [ReadOnly] public bool notOP; //NOT연산 결과
    [ReadOnly] public bool ifOP; //삼항 연산 결과
    [ReadOnly] public string ifOPstring; //삼항 연산 결과 문자
    [ReadOnly] public string ageOP;

    [ReadOnly] public string bmiOP;

    void Start()
    {

        // % 나머지 연산자로 A, B를 연산하기 -> 로그
        // %연산자 용 메소드를 만든다
        
        //float mod = modulo(A,B);
        //string result = $"나머지 연산={mod}";
        //Debug.Log(result);


        //Debug.Log (TA == TB);
        //Debug.Log(TA != TB);
        //Debug.Log (TA.Length <= TB.Length);
        //Debug.Log (TA.Length >= TB.Length);
        //Debug.Log (TA.Length > TB.Length);
        //Debug.Log (TA.Length < TB.Length);

        //논리연산.
        // && 그리고 (AND연산) : 모두가 참 일때 True
        // || 또는   (OR연산)  : 둘 중 하나만 참 일때 True
        // !  아니다 (NOT연산) :
        
        //반환:True, False 순서는 


        //삼항연산
        //조건1 ? TRUE : FALSE;

    }

     public int ageString = 20;

    void Update()
    {
        andOP = (A == B) ;
        andOP = (A > B) ;
        andOP = true == true ;
        andOP = ba && bb && bc ;
        orOP = ba || bb || bc ;
        notOP= !ba;
        
        ifOP = ba == bb ? true : false;
        //ifOP = ba == bb ;

        ifOPstring = ba == bb ? "ba,bb가 같다" : "ba,bb가 다르다";
        //변수 = xx ? yy : zz;
        int age = 20;
        ageOP =age > 19?"성인":"미성년";



    }    

    //나머지 연산자
    float modulo(float x,float y)
    {
        return x % y;
    }

 


    // bool : True, False
    //비교 연산( 왼쪽 기준으로 오른쪽이 비교 대상)
   // bool CompareOp(int x, int y)
   // {
        // == 같으면 True : 다르면 False
        // 7 >= 16 앞에꺼 기준으로 뒤에껄 봄으로 False
        // != ?
        // <= (이하)
        // >= (이상)
        // < (미만)
        // > (초과)
        //return x == y
     // }
}