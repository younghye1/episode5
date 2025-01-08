using UnityEngine;

public class VariableDialog : MonoBehaviour
{
   
    [Header("캐릭터")]
   
    public string 캐릭터1 ="철수:";
    public string 캐릭터2="영희:";


    [Header("대사")]
    public string text1= "안녕, 오늘 날씨 정말 좋다!";
    public string text2= "그러게, 온도가 어떻게 돼?";
    public string text3= "야";
    public string text4= "꽃들도 예쁘게 피었더라.";
    public string text5= "그래, 지금 몇시야?";
    public string text6= "시야";
    public string text7= "근처 공원으로 가자";
    
    public string text8="";
    
    public string text9="은?";
    public string text10="야";




    [Header("환경")]
    
    public float 온도 =0.0f;
    public int 시계;
    public bool 선택;
    public int 구구단1;
    public int 구구단2;
    public int 구구단3;

    void Start()
    {
        string result1= $"{캐릭터1}{text1}\n";
        string result2= $"{캐릭터2}{text2}\n";
        string result3= $"{캐릭터1}{text3}\n";
        string result4= $"{캐릭터2}{text4}\n";
        string result5= $"{캐릭터1}{text5}\n";
        string result6= $"{캐릭터2}{text6}\n";
        string result7= $"{캐릭터1}{text7}\n";
        string result8= $"{캐릭터2}{선택}{text8}\n";
        string result9= $"{캐릭터1}{구구단1}x{구구단2}{text9}\n";
        string result10= $"{캐릭터2}{구구단3}{text10}\n";

        Debug.Log($"{result1}{result2}{result3}{result4}{result5}{result6}{result7}{result8}{result9}{result10}");
    }
}
