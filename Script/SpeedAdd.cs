using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedAdd : MonoBehaviour
{
    public float FirstSpeed ;  //移動初速度
    public float Speedinterval;               //速度增加產生的間隔時間
    public float Speedadd;               //速度增加量
    private static float dtimespeed = 0.0f;   //時間累計變數 速度

    public static float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(POINT.STime == 0 )
        {
            speed = FirstSpeed;
            //dtimespeed = 0.0f;   //歸零重新計數
        }
    
        if(dtimespeed > Speedinterval)
        {
            speed -= Speedadd;
            dtimespeed = 0.0f;   //歸零重新計數
        }
        else
        {
            dtimespeed += Time.deltaTime;   //累計時間
        }

    }
    
}
