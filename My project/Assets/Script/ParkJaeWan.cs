using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class ParkJaeWan : MonoBehaviour
{
    private string name = "박재완";
    private int age = 32;
    private string MBTI = "INFP";
    private float tall = 165.4f;
    private string NickName = "완두콩";
    private long wantmoney = 9223372036854775807;
    private bool Kindness = true;
    private string BloodType = "A";
    private string FavoritFood = "면";
    private string Hobby = "게임";


    // Start is called before the first frame update
    void Awake()
    {
        Introduce();

    }

    // Update is called once per frame

     void Introduce()
    {
     Debug.Log("제 이름은 " + name + "입니다.");
     Debug.Log("나이는 " + age + "살");
     Debug.Log("MBTI는 " + MBTI + " 입니다.");
     Debug.Log("키도 궁금해 하시다니... " + tall + "입니다.");
     Debug.Log("어렸을 적 별명은 " + NickName + "이구요. 게임 닉네임으로 가끔 쓰고 있습니다.");
     Debug.Log("돈 많이 벌고 싶어서 int말고 long으로 썼습니다. 돈 " + wantmoney+ "원 벌고 싶습니다. 달러도 좋습니다.");
     Debug.Log("My Kindness is " + Kindness);
     Debug.Log("혈액형은 " + BloodType + "형. 수혈 안 해줘요.");
     Debug.Log("좋아하는 음식은 " + FavoritFood + "을 사랑합니다.");
     Debug.Log("이상 제 소개를 마칩니다. 저는 " + name + "이었습니다. 감사합니다.");
    }
}*/

using TMPro;
using UnityEngine.UI;

public class ParkJaeWan : MonoBehaviour
{
    // UI 연결용 public 변수
    public TextMeshProUGUI infoText;
    public Button insButton;

    private string name = "박재완";
    private int age = 32;
    private string MBTI = "INFP";
    private float tall = 165.4f;
    private string NickName = "완두콩";
    private long wantmoney = 9223372036854775807;
    private bool Kindness = true;
    private string BloodType = "A";
    private string FavoritFood = "면";
    private string Hobby = "게임";

    void Start()
    {
        // 버튼에 클릭 이벤트 연결
        insButton.onClick.AddListener(Introduce);
    }

    void Introduce()
    {
        string result = "";
        result += "이름: " + name + "\n";
        result += "나이: " + age + "\n";
        result += "MBTI: " + MBTI + "\n";
        result += "키: " + tall + "cm\n";
        result += "닉네임: " + NickName + "\n";
        result += "희망 연봉: " + wantmoney + "원\n";
        result += "친절한가요?: " + (Kindness ? "네" : "아니요") + "\n";
        result += "혈액형: " + BloodType + "\n";
        result += "좋아하는 음식: " + FavoritFood + "\n";
        result += "취미: " + Hobby;

        // TMP에 출력
        infoText.text = result;
    }
}
