using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
				this.GetComponent<Text> ().text = "Your Score " + PlayerScore.player_score [0] + "pt\n" + "Time " +  TimeCounter.endtime + "s";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
