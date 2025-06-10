using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Star_Create : MonoBehaviour
{
    string star;
    int count = 0;

    private void Awake()
    {
        count = 0;
    }
    public void plus_star()
    {
        star += "★";
    }

    public void plus_empty()
    {
        star += "　";
    }

    // Start is called before the first frame update
    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }
    public void Phase1()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int t =0; t <= i; t++)
            {
                plus_star();
            }
            star += "\n";
        }
       // star += "★"; // 별
       // star += "　"; // 빈칸
       // star += "\n"; // 줄바꿈
       // 페이즈 1


        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int z = 3; z >= i; z--)
            {
                plus_empty();
            }
            for (int t = 0; t <= i; t++)
            {
                plus_star();
            }
            star += "\n";
        }
        // 페이즈 2


        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int t = 0; t <= i; t++)
            {
                plus_star();
            }
            star += "\n";
        }
        for (int i = 0; i < 5; i++)
        {
            for (int z = 3; z >= i; z--)
            {
                plus_star();
            }
            star += "\n";
            // 페이즈 3

        }
            Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int z = 3; z >= i; z--)
            {
                plus_empty();
            }
            for (int t = 0; t <= i; t++)
            {
                plus_star();
            }
            star += "\n";
        }
        for (int i = 0; i < 5; i++)
        {
            for (int z = 0; z <= i; z++)
            {
                plus_empty();
            }
            for (int t = 3; t >= i; t--)
            {
                plus_star();
            }
            star += "\n";
        }
        // 페이즈 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int z = 3; z >= i; z--)
            {
                plus_empty();
            }
            for (int t = 0; t <= 2*i; t++)
            {
                plus_star();
            }
            star += "\n";
        }
        for (int i = 0; i < 5; i++)
        {
            for (int z = 0; z <= i; z++)
            {
                plus_empty();
            }
            for (int t = 6; 2*i <= t; t--)
            {
                plus_star();
            }
            star += "\n";
        }
        // 페이즈 5


        Debug.Log(star);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
