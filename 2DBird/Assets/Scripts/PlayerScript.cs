using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    float JumpVelocity = 10;  // ジャンプ力

    Rigidbody2D rb2d;
    Animator amn;
    SpriteRenderer spr;

    [SerializeField]
    private Sprite sp;

    static public bool flag;

    void Start()
    {
        flag = false;
        rb2d = GetComponent<Rigidbody2D>();
        amn = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        TouchManager.Began += (info) =>
        {
            if (!flag)
            {
                rb2d.velocity = Vector2.zero; // 落下速度リセットする
                rb2d.AddForce(transform.up * JumpVelocity, ForceMode2D.Impulse);    // 上方向に力を加える
            }
        };
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(amn);
        SpriteRenderer renderer = spr;
        renderer.sprite = sp;
        flag = true;
    }
}
