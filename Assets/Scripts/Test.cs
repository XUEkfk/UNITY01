using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float moveSpeed = 5f;
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
        
    }
}
