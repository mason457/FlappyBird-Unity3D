using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //引用場景管理功能

public class PlayerAI : MonoBehaviour
{
    public float jumpPower;    //跳躍力
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Debug.Log("主角啟動...");
        //jumpPower = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //jumpPower = jumpPower + 0.1f;
        if(Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0 , jumpPower, 0);
        }
        //跳躍操控處理
    }

    void OnCollisionEnter(Collision other)
    {
        //if(Input.GetButtonDown("Jump"))
        //{
            target.SetActive(true);
            Time.timeScale = 0;
        //}
        //else
        //{}
    } //進入碰撞事件
}
