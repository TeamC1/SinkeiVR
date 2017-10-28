using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

//	public Text Player_score;
	public int score;
//	public int player;
	//static public int playerchecker;
	public static int[] player_score = {0,0};
	public int whoiswin;



	// Use this for initialization
	void Start () {
			this.GetComponent<Text>().text = "Player1 " + player_score[0].ToString() + "pt\n"/* + "Player2 " + player_score[1].ToString() + "pt"*/;
			score = 0;

	}

	// Update is called once per frame
	void Update () {
	 // int playerscore;
		if(score != 0){
			player_score[/*player*/0] = player_score[0/*player*/] + score;
			this.GetComponent<Text>().text = "Player1 " + player_score[/*1*/0].ToString() + "pt\n"/* + "Player2 " + player_score[0].ToString() + "pt"*/;

			//Player_score.text = string.Format ("Score " + player_score);
			score = 0;
	  }
	}

//	public int Result(){
//				if (player_score [0] < player_score [1]) {
//					 whoiswin = 1;
//				} else if (player_score [0] > player_score [1]) {
//					 whoiswin = 2;
//				} else whoiswin = 3;
//
//				return whoiswin;
//	}
}
