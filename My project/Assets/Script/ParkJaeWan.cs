using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class ParkJaeWan : MonoBehaviour
{
    private string name = "�����";
    private int age = 32;
    private string MBTI = "INFP";
    private float tall = 165.4f;
    private string NickName = "�ϵ���";
    private long wantmoney = 9223372036854775807;
    private bool Kindness = true;
    private string BloodType = "A";
    private string FavoritFood = "��";
    private string Hobby = "����";


    // Start is called before the first frame update
    void Awake()
    {
        Introduce();

    }

    // Update is called once per frame

     void Introduce()
    {
     Debug.Log("�� �̸��� " + name + "�Դϴ�.");
     Debug.Log("���̴� " + age + "��");
     Debug.Log("MBTI�� " + MBTI + " �Դϴ�.");
     Debug.Log("Ű�� �ñ��� �Ͻôٴ�... " + tall + "�Դϴ�.");
     Debug.Log("����� �� ������ " + NickName + "�̱���. ���� �г������� ���� ���� �ֽ��ϴ�.");
     Debug.Log("�� ���� ���� �; int���� long���� ����ϴ�. �� " + wantmoney+ "�� ���� �ͽ��ϴ�. �޷��� �����ϴ�.");
     Debug.Log("My Kindness is " + Kindness);
     Debug.Log("�������� " + BloodType + "��. ���� �� �����.");
     Debug.Log("�����ϴ� ������ " + FavoritFood + "�� ����մϴ�.");
     Debug.Log("�̻� �� �Ұ��� ��Ĩ�ϴ�. ���� " + name + "�̾����ϴ�. �����մϴ�.");
    }
}*/

using TMPro;
using UnityEngine.UI;

public class ParkJaeWan : MonoBehaviour
{
    // UI ����� public ����
    public TextMeshProUGUI infoText;
    public Button insButton;

    private string name = "�����";
    private int age = 32;
    private string MBTI = "INFP";
    private float tall = 165.4f;
    private string NickName = "�ϵ���";
    private long wantmoney = 9223372036854775807;
    private bool Kindness = true;
    private string BloodType = "A";
    private string FavoritFood = "��";
    private string Hobby = "����";

    void Start()
    {
        // ��ư�� Ŭ�� �̺�Ʈ ����
        insButton.onClick.AddListener(Introduce);
    }

    void Introduce()
    {
        string result = "";
        result += "�̸�: " + name + "\n";
        result += "����: " + age + "\n";
        result += "MBTI: " + MBTI + "\n";
        result += "Ű: " + tall + "cm\n";
        result += "�г���: " + NickName + "\n";
        result += "��� ����: " + wantmoney + "��\n";
        result += "ģ���Ѱ���?: " + (Kindness ? "��" : "�ƴϿ�") + "\n";
        result += "������: " + BloodType + "\n";
        result += "�����ϴ� ����: " + FavoritFood + "\n";
        result += "���: " + Hobby;

        // TMP�� ���
        infoText.text = result;
    }
}
