using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneToTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //SteamVR_TrackedObject trackObject = GetComponent<SteamVR_TrackedObject>();
        //var device = SteamVR_Controller.Input((int)trackObject.index);
        //if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
		if(Input.GetKeyDown(KeyCode.C)){
						SceneManager.LoadScene ("title 1");
				}
		}
}
