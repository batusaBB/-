﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 右操作 : MonoBehaviour {
    Rigidbody2D r2;

	// Use this for initialization
	void Start () {
        this.r2 = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))//移動
        {
            transform.Translate(0.2f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))//移動
        {
            transform.Translate(-0.2f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && this.r2.velocity.y == 0)//ジャンプ
        {
            this.r2.AddForce(transform.up * 300);
        }
        if (transform.position.y < -8)//勝利演出
        {
            SceneManager.LoadScene("1p勝利");
        }
    }
}
