using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Gatcha : MonoBehaviour
{
    public TextMeshProUGUI Txt_Bumin;
    List<string> characterList_5S = new List<string>();
    List<string> characterList_5SS = new List<string>();
    List<string> characterList_4S = new List<string>();

    int count = 0;
    bool count5 = false;

    private void Awake()
    {
        count = 0;
        count5 = false;
    }
    // Start is called before the first frame update


    void Start()
    {
        // 5성 일반(픽뚫)캐릭터
        characterList_5S.Add("다이루크");
        characterList_5S.Add("데히야");
        characterList_5S.Add("각청");
        characterList_5S.Add("타이나리");
        characterList_5S.Add("모나");
        characterList_5S.Add("치치");
        characterList_5S.Add("진");
        characterList_5S.Add("유메미즈키 미즈키");

        // 5성 픽업 캐릭터
        characterList_5SS.Add("벤티");
        characterList_5SS.Add("종려");
        characterList_5SS.Add("라이덴 쇼군");
        characterList_5SS.Add("나히다");
        characterList_5SS.Add("푸리나");
        characterList_5SS.Add("마비카");

        // 4성 캐릭터
        characterList_4S.Add("엠버");
        characterList_4S.Add("바바라");
        characterList_4S.Add("설탕");
        characterList_4S.Add("리사");
        characterList_4S.Add("콜레이");
        characterList_4S.Add("케이아");
        characterList_4S.Add("노엘");
    }
    public void Gacha()
    {
        int gatcharnum5 = Random.Range(0, characterList_5S.Count);  // 8 , 0 ~ 7)
        int gatcharnum6 = Random.Range(0, characterList_5SS.Count);  // 6 , 0 ~ 5)
        int gatcharnum4 = Random.Range(0, characterList_4S.Count);  // 8 , 0 ~ 7)
        int gatcharnum = Random.Range(1, 101);
        int gatchar5snum = Random.Range(1, 11);
        for (int i = 0; i < 10; i++)
        {
            gatcharnum = Random.Range(1, 101);
            if (count == 9)
            {
                gatchar5snum = Random.Range(1, 11);

                if (count5 == true)
                {
                    gatcharnum6 = Random.Range(0, characterList_5SS.Count);
                    Debug.Log(characterList_5SS[gatcharnum6]);
                    count = 0;
                    count5 = false;
                }
                else if (gatchar5snum <= 5)
                {
                    gatcharnum5 = Random.Range(0, characterList_5S.Count);
                    Debug.Log(characterList_5S[gatcharnum5]);
                    count = 0;
                    count5 = true;
                }
                else
                {
                    gatcharnum6 = Random.Range(0, characterList_5SS.Count);
                    Debug.Log(characterList_5SS[gatcharnum6]);
                    count = 0;
                    count5 = false;
                }

            }
            else if (gatcharnum <= 5)
            {
                gatchar5snum = Random.Range(1, 11);

                if (count5 == true)
                {
                    gatcharnum6 = Random.Range(0, characterList_5SS.Count);
                    Debug.Log(characterList_5SS[gatcharnum6]);
                    count = 0;
                    count5 = false;
                }
                else if (gatchar5snum <= 5)
                {
                    gatcharnum5 = Random.Range(0, characterList_5S.Count);
                    Debug.Log(characterList_5S[gatcharnum5]);
                    count = 0;
                    count5 = true;
                }
                else
                {
                    gatcharnum6 = Random.Range(0, characterList_5SS.Count);
                    Debug.Log(characterList_5SS[gatcharnum6]);
                    count = 0;
                    count5 = false;
                }
            }
            else
            {
                gatcharnum4 = Random.Range(0, characterList_4S.Count);
                Debug.Log(characterList_4S[gatcharnum4]);
                count++;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
