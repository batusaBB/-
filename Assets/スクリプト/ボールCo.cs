using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ボールCo : MonoBehaviour {
    Rigidbody2D r2;

	// Use this for initialization
	void Start () {
        this.r2 = GetComponent<Rigidbody2D>();
        this.r2.AddForce(transform.right * 350);//初速
	}
	
	// Update is called once per frame
	void Update () {
        //勝利シーン移行
        if (transform.position.x > 13.5)
        {
            SceneManager.LoadScene("1p勝利");
        }
        if (transform.position.x < -13.5)
        {
            SceneManager.LoadScene("2p勝利");
        }
	}
}
