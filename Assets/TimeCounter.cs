using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

		public GameObject manager = null;
		public float timeCounter = 250f;
		public bool timerstart = false;
		public bool timerend = false;
		static public int endtime = 0;

	// Use this for initialization
	void Start () {
				endtime = (int)timeCounter;
				this.GetComponent<Text> ().text = "Time " + timeCounter + "s";

	}
	
	// Update is called once per frame
	void Update () {
//				this.GetComponent<Text> ().text = "Time " + maxTime "s";
				if (timerstart) {
						timeCounter -= Time.deltaTime;

						timeCounter = Mathf.Max (timeCounter, 0.0f);
						GetComponent<UnityEngine.UI.Text> ().text = "Time " + ((int)timeCounter).ToString () + "s";

				}

				if (timeCounter == 0f) {
						SinkeiManager mgr = manager.GetComponent<SinkeiManager> ();
						mgr.timeout = true;
				}

				if (timerend && timerstart==false) {
						endtime -= (int)timeCounter;
				}
		
	}
				
}
