using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HK : MonoBehaviour {
    private GameObject chara;
    // Use this for initialization
    void Start () {
         chara = GameObject.Find("王(ハート)");
        Debug.Log(chara);
        chara.transform.position = gameObject.transform.position;
        chara.transform.rotation = gameObject.transform.rotation;
        chara.transform.localScale = new Vector3(0.5F, 0.5F, 0.5F);

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void appear(GameObject obj)
    {
        if (obj.name != "Hk")
        {
            return;
        }

        chara.SetActive(true);

        return;
    }

    public void disappear(GameObject obj)
    {
        if (obj.name != "HK")
        {
            return;
        }

        chara.SetActive(false);

        return;
    }
}
