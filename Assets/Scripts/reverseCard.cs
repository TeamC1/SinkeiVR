using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class reverseCard : MonoBehaviour {

	private AudioSource sound01;
//	public AudioSource mute;

	public GameObject manager = null;
	public int id = 1;
	//int check = 0;
	bool face = false;
	// Use this for initialization
	void Start () {
		if(manager == null){
			Debug.LogError("unset manager");
			return;
		}
		//		mute = GetComponent<AudioSource> ();
				AudioSource[] audioSource = GetComponents<AudioSource>();
				sound01 = audioSource[0];
		//		mute.mute = true;

	}

	// Update is called once per frame
	void Update () {

	}

	public void Reverse(){
		if(face) return;

				sound01.PlayOneShot(sound01.clip);

		iTween.MoveBy(gameObject,
			iTween.Hash(
			"z",2.0f,
			"time",1.0f)
			);
		iTween.RotateAdd(gameObject,
			iTween.Hash(
			"y",180.0f,
			"time",.5f,
			"delay",1.1f)
			);
		iTween.MoveAdd(gameObject,
			iTween.Hash(
			"z",2.0f,
			"time",1.0f,
			"delay",1.7f,
			"oncomplete","Complete")
			);
		face = true;
        //check = 1;

        HK app = GetComponent<HK>();
        app.appear(gameObject);


    }

    public void ReSet(){

        iTween.MoveBy(gameObject,
			iTween.Hash(
			"z",-1.0f,
			"time",1.0f)
			);
		iTween.RotateAdd(gameObject,
			iTween.Hash(
			"y",180.0f,
			"time",.5f,
			"delay",1.1f)
			);
		iTween.MoveAdd(gameObject,
			iTween.Hash(
			"z",-1.0f,
			"time",1.0f,
			"delay",1.7f,
			"oncomplete","Faceisfalse"
			)
			);


        HK app = GetComponent<HK>();
        app.disappear(gameObject);

        //face = false;
        //check = 0;
    }

    private void Complete(){
		//else if(check == 1 ){
		//face = true;
		SinkeiManager mgr = manager.GetComponent<SinkeiManager>();
        //SpawnObj2 spw = manager.GetComponent<SpawnObj2>();
//		SinkeiManagerTest mgr = manager.GetComponent<SinkeiManagerTest>();
		mgr.ReversePost(id,gameObject);
        //Debug.Log(spw);
        //spw.Spawn(gameObject);
		//}
	}

	private void Faceisfalse(){
		face = false;
	}
}
