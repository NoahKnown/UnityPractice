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
        // 5�� �Ϲ�(�ȶ�)ĳ����
        characterList_5S.Add("���̷�ũ");
        characterList_5S.Add("������");
        characterList_5S.Add("��û");
        characterList_5S.Add("Ÿ�̳���");
        characterList_5S.Add("��");
        characterList_5S.Add("ġġ");
        characterList_5S.Add("��");
        characterList_5S.Add("���޹���Ű ����Ű");

        // 5�� �Ⱦ� ĳ����
        characterList_5SS.Add("��Ƽ");
        characterList_5SS.Add("����");
        characterList_5SS.Add("���̵� �");
        characterList_5SS.Add("������");
        characterList_5SS.Add("Ǫ����");
        characterList_5SS.Add("����ī");

        // 4�� ĳ����
        characterList_4S.Add("����");
        characterList_4S.Add("�ٹٶ�");
        characterList_4S.Add("����");
        characterList_4S.Add("����");
        characterList_4S.Add("�ݷ���");
        characterList_4S.Add("���̾�");
        characterList_4S.Add("�뿤");
    }
    public void Gacha()
    {
        int gatcharnum5S = Random.Range(0, characterList_5S.Count);  // 8 , 0 ~ 7)
        int gatcharnum5SS = Random.Range(0, characterList_5SS.Count);  // 6 , 0 ~ 5)
        int gatcharnum4S = Random.Range(0, characterList_4S.Count);  // 8 , 0 ~ 7)
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
                    gatcharnum5SS = Random.Range(0, characterList_5SS.Count);
                    Debug.Log(characterList_5SS[gatcharnum5SS]);
                    count = 0;
                    count5 = false;
                }
                else if (gatchar5snum <= 5)
                {
                    gatcharnum5S = Random.Range(0, characterList_5S.Count);
                    Debug.Log(characterList_5S[gatcharnum5S]);
                    count = 0;
                    count5 = true;
                }
                else
                {
                    gatcharnum5SS = Random.Range(0, characterList_5SS.Count);
                    Debug.Log(characterList_5SS[gatcharnum5SS]);
                    count = 0;
                    count5 = false;
                }

            }
            else if (gatcharnum <= 5)
            {
                gatchar5snum = Random.Range(1, 11);

                if (count5 == true)
                {
                    gatcharnum5SS = Random.Range(0, characterList_5SS.Count);
                    Debug.Log(characterList_5SS[gatcharnum5SS]);
                    count = 0;
                    count5 = false;
                }
                else if (gatchar5snum <= 5)
                {
                    gatcharnum5S = Random.Range(0, characterList_5S.Count);
                    Debug.Log(characterList_5S[gatcharnum5S]);
                    count = 0;
                    count5 = true;
                }
                else
                {
                    gatcharnum5SS = Random.Range(0, characterList_5SS.Count);
                    Debug.Log(characterList_5SS[gatcharnum5SS]);
                    count = 0;
                    count5 = false;
                }
            }
            else
            {
                gatcharnum4S = Random.Range(0, characterList_4S.Count);
                Debug.Log(characterList_4S[gatcharnum4S]);
                count++;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
