using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkJaeWan : MonoBehaviour
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
}
