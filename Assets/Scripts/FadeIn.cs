using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour {

		float speed = 0.0001f;  //透明化の速さ
		public float alfa=0;    //A値を操作するための変数
		float red, green, blue;    //RGBを操作するための変数

	// Use this for initialization
	void Start () {
				red = GetComponent<Image>().color.r;
				green = GetComponent<Image>().color.g;
				blue = GetComponent<Image>().color.b;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
//		public void Fade(){
////				GetComponent<Image>().color = new Color(red, green, blue, alfa);
////				while(alfa<1) alfa += speed;
//						PlayerScore ps = GameObject.Find("Player_score").GetComponent<PlayerScore>();
//								if (ps.Result () == 1) {
//										SceneManager.LoadScene ("result1");
//								} else if (ps.Result () == 2) {
//										SceneManager.LoadScene ("result2");
//								} else if (ps.Result () == 3) {
//										SceneManager.LoadScene ("draw");
//								}
//				}

//						GameObject.Find ("GameManeger").GetComponent<SinkeiManager> ().fadechecker = true;


}
