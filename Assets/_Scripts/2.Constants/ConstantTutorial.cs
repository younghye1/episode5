// 네임스페이스 영역
using UnityEngine;

// 클래스 영역
public class ConstantTutorial : MonoBehaviour
{
    #region 멤버 변수
    // (멤버) 변수 영역
       
        //Attribute
        [Header("스코어")]
        public int score1;

        public const int MAX_SCORE = 166;

        [ReadOnly]
        public int score3;

    #endregion

    #region 상수



    #endregion

    #region 메소드
    // (Method) 함수 영역
    
        private void Start ()
        {
            score1 = 7;

        }

        private void Update ()
        {
            //지역 변수
            score3 = score1; //순서 지켜야 함
        }
    #endregion

}