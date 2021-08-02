using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawenerAI : MonoBehaviour
{
    public GameObject wallPrefab;        //用來產生敵人的素材
    public float range = 3.0f;            //垂直(Y)偏移上下限
    public float interval;               //產生的間隔時間
    private static float dtime = 0.0f;   //時間累計變數

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dtime >= interval)
        {
            transform.position = new Vector3(transform.position.x , Random.Range(-range , range) , transform.position.z);  //敵人隨機
            Instantiate(wallPrefab , transform.position,transform.rotation);  //敵人新增
            Debug.Log("新增敵人...");
            dtime = 0.0f;   //歸零重新計數
        }
        else
        {
            dtime += Time.deltaTime;   //累計時間
        }
       
    }
}
