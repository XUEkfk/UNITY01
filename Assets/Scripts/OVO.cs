using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            // 偵測鍵盤按鍵是否被按下
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("空白鍵被按下！");
            }

            // 偵測鍵盤按鍵是否持續按住
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("W 鍵被按下！");
            }

            // 偵測鍵盤按鍵是否釋放
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A 鍵被按下！");
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("S 鍵被按下!");
            }
            
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("D 鍵被按下!");
            }
        }   
    }
}
