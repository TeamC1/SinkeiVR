using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class reverseCard : MonoBehaviour {

	private AudioSource sound01;
//	public AudioSource mute;

	public GameObject manager = null;
	public int id = 1;
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
			"y",2.0f,
			"time",1.0f)
			);
		iTween.RotateAdd(gameObject,
			iTween.Hash(
			"z",180.0f,
			"time",.5f,
			"delay",1.1f)
			);
		iTween.MoveAdd(gameObject,
			iTween.Hash(
			"y",2.0f,
			"time",1.0f,
			"delay",1.7f,
			"oncomplete","Complete")
			);
		face = true;


	}
	
	public void ReSet(){
		iTween.MoveBy(gameObject,
			iTween.Hash(
			"y",-1.0f,
			"time",1.0f)
			);
		iTween.RotateAdd(gameObject,
			iTween.Hash(
			"z",180.0f,
			"time",.5f,
			"delay",1.1f)
			);
		iTween.MoveAdd(gameObject,
			iTween.Hash(
			"y",-1.0f,
			"time",1.0f,
			"delay",1.7f)
			);
		face = false;
	}
	
	private void Complete(){
		SinkeiManager mgr = manager.GetComponent<SinkeiManager>();
		mgr.ReversePost(id,gameObject);
	}
}
