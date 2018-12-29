﻿using System.Collections;
using UnityEngine;


public class Player : MonoBehaviour {

    //移動スピード
    public float speed = 5;

    //playerBulletプレハブ
    public GameObject bullet;

    //Startメソッドをコルーチンとして呼び出す
    private IEnumerator Start()
    {
        while (true)
        {
            //弾をプレイヤーと同じ位置/角度で作成
            Instantiate(bullet, transform.position, transform.rotation);
            //0.05秒待つ
            yield return new WaitForSeconds(0.05f);





        }  
    }


    // Update is called once per frame
    void Update () {

        //右・左
        float x = Input.GetAxisRaw("Horizontal");

        //上・下
        float y = Input.GetAxisRaw("Vertical");

        //移動する向きを求める
        Vector2 direction = new Vector2(x, y).normalized;

        //移動する向きとスピードを代入する
        GetComponent<Rigidbody2D>().velocity = direction * speed;

	}
}