using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnCounter : MonoBehaviour {

	public int count = 1;
	public bool check = false;

	// Use this for initialization
	void Start () {
		this.GetComponent<Text> ().text = "Turn " + count.ToString ();
		
	}
	
	// Update is called once per frame
	void Update () {
			if(check == true){
				count++;

				this.GetComponent<Text> ().text = "Turn " + count.ToString ();
				check = false;
		
				
			}
	}
}
