using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class メイン移行 : MonoBehaviour {

	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {

            Debug.Log("メインへ");
            SceneManager.LoadScene("メイン");
            
        }
	}
}
