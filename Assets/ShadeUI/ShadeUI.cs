using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadeUI : MonoBehaviour
{
	public float DisOfCam;
	public float UIShadeSpeed;
	private Vector3 DisOfUIAndCam;
	private bool IsOpenedUI = false;
	private bool IsUIActive = false;

	// Use this for initialization
	void Start ()
	{
		gameObject.transform.position = Camera.main.transform.position + new Vector3 (5f, -1f, DisOfCam);

		Vector3 CamPos = Camera.main.transform.position + new Vector3 (0f, -1f, DisOfCam);
		DisOfUIAndCam = CamPos - gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.Space)) {
			if (!IsUIActive) {
				if (!IsOpenedUI) {
					StartCoroutine ("OpenUI");
				} else {
					StartCoroutine ("CloseUI");
				}
			}
		}
	}

	IEnumerator OpenUI ()
	{
		Rigidbody UIRigid = gameObject.GetComponent<Rigidbody> ();
		UIRigid.velocity = DisOfUIAndCam / UIShadeSpeed;
		IsUIActive = true;

		yield return new WaitForSeconds (UIShadeSpeed);

		IsUIActive = false;
		UIRigid.velocity = new Vector3 (0f, 0f, 0f);
		IsOpenedUI = true;
	}

	IEnumerator CloseUI ()
	{
		Rigidbody UIRigid = gameObject.GetComponent<Rigidbody> ();
		UIRigid.velocity = -DisOfUIAndCam / UIShadeSpeed;
		IsUIActive = true;

		yield return new WaitForSeconds (UIShadeSpeed);

		IsUIActive = false;
		UIRigid.velocity = new Vector3 (0f, 0f, 0f);
		IsOpenedUI = false;
	}
}
