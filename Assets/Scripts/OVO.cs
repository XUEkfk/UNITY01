using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVO : MonoBehaviour
{
    public float moveSpeed = 5f; // 角色的移動速度
    private Rigidbody2D rb; // 2D 物理剛體
    private Vector2 movement; // 移動向量
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 獲取剛體組件
    }

    // Update is called once per frame
    void Update()
    {
        // 初始化水平和垂直方向的移動值
        float moveX = 0f;
        float moveY = 0f;

        // 偵測鍵盤按鍵是否持續按住
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f; // 按住 W 鍵向上移動
            Debug.Log("W GetKeyDowm");
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f; // 按住 A 鍵向左移動
            Debug.Log("A GetKeyDowm");
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f; // 按住 S 鍵向下移動
            Debug.Log("S GetKeyDowm");
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f; // 按住 D 鍵向右移動
            Debug.Log("D GetKeyDowm");
        }

        // 將水平和垂直方向的移動值存入移動向量
        movement = new Vector2(moveX, moveY).normalized;
    }

    // 使用 FixedUpdate 來處理物理更新
    void FixedUpdate()
    {
        // 移動角色
        rb.velocity = movement * moveSpeed;
    }
}