using UnityEngine;

public class shot : MonoBehaviour {

    Transform Muzzle_transform;

    public GameObject bullet;

    private GameObject refObj;

    // Use this for initialization
    void Start() {

//		Muzzle_transform = GameObject.Find("[CameraRig]/Controller (right)/wand/muzzle").transform;
		Muzzle_transform = GameObject.Find("muzzle").transform;

    }

    // Update is called once per frame
    void Update() {

//        SteamVR_TrackedObject trackObject = GetComponent<SteamVR_TrackedObject>();
//        var device = SteamVR_Controller.Input((int)trackObject.index);

//		if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
		if (Input.GetMouseButtonDown(0)) {
            refObj = Instantiate(bullet, Muzzle_transform.position, Muzzle_transform.rotation) as GameObject;
        }
    }
}
