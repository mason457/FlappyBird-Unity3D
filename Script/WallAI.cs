using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAI : MonoBehaviour
{
    public float speedFirst ;  //移動初速度
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(SpeedAdd.speed * Time.deltaTime, 0 , 0);  //位置移動處理
    }
}
