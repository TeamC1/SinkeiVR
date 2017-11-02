using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearHk : MonoBehaviour
{

    GameObject HK;



    // Use this for initialization
    public void Ready()
    {
        HK = GameObject.Find("王(ハート)");
        Debug.Log(HK);
        var ef = Instantiate(HK);

        
    }


}
