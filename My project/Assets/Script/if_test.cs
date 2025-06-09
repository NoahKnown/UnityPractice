using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class if_test : MonoBehaviour
{
    int count;
    public int selectNumber = 0;
    private void Awake()
    {
        count = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        /*
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다.(1-100)
        Debug.Log($"랜덤한 값은 {randomValue} 입니다.");
        //확률이 10%면 로그에 '각청'을 뽑았다!
        //확률이 20%면 로그에 '모나'을 뽑았다!
        //확률이 70%면 로그에 '치치'을 뽑았다!

        if(randomValue <= 10) // randomValue가 10보다 같거나 작으면
        {
            Debug.Log("각청을 뽑았다!");
        }
        else if(randomValue <= 30) // randomValue가 30보다 같거나 작으면
        {
            Debug.Log("모나를 뽑았다!");
        }
        else
        {
            Debug.Log("치치를 뽑았다!");
        }
        int newValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다.(1-100)
        Debug.Log($"랜덤한 값은 {newValue} 입니다.");
        //확률이 10%면 로그에 '각청'을 뽑았다!
        //확률이 20%면 로그에 '모나'을 뽑았다!
        //확률이 70%면 로그에 '치치'을 뽑았다!

        if (newValue <= 50) // newValue가 50보다 같거나 작으면
        {
            if (newValue <= 10)
            {
                Debug.Log("픽뚫! 각청를 뽑았다!");
            }
            else if (newValue <= 30) // randomValue가 30보다 같거나 작으면
            {
                Debug.Log("픽뚫! 모나를 뽑았다!");
            }
            else
            {
                Debug.Log("픽뚫! 치치를 뽑았다!");
            }
        }
        else
        {
            Debug.Log("픽업! 아야카를 뽑았다!");
        }*/
    }

    
    public void Gatcha()
    {
        int number = 1;


     //   for (number=1; number <= 10; number++)
        while(number<=10)
        {
            int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다.(1-100)
            Debug.Log($"랜덤한 값은 {randomValue} 입니다.");
            //확률이 10%면 로그에 '각청'을 뽑았다!
            //확률이 20%면 로그에 '모나'을 뽑았다!
            //확률이 70%면 로그에 '치치'을 뽑았다!
            if (8 <= count)
            {
                Debug.Log("확정으로 '각청'을 뽑았다!");
                count = 0;
            }
            else if (randomValue <= 10) // randomValue가 10보다 같거나 작으면
            {
                Debug.Log("각청을 뽑았다!");
            }
            else if (randomValue <= 30) // randomValue가 30보다 같거나 작으면
            {
                Debug.Log("모나를 뽑았다!");
            }
            else
            {
                Debug.Log("치치를 뽑았다!");
            }

            count++;
            Debug.Log($"현재 카운트는 {count} 입니다.");
            number++;
        }
    }
    /*
    public void GatchaSwitch()
    {
        int randomValue = Random.Range(1, 101);

        switch (selectNumber)
        {
            case 0:
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'노엘'을(를) 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("윽 픽뚫이다!");
                    }
                }
                break;

            case 1:
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'아야카'을(를) 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("윽 픽뚫이다!");
                    }
                }
                break;

            case 2:
                {
                if (randomValue <= 10) // 1 ~ 10 -> 10%
                {
                    Debug.Log("'미코'을(를) 뽑았다!");
                }
                else
                {
                    Debug.Log("윽 픽뚫이다!");
                }
        }
        break;

        default:
                Debug.Log("'치치'을(를) 뽑았다!");
                break;
        }
    }*/
    // Update is called once per frame
    void Update()
    {
    }
}
