using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObjects : MonoBehaviour {

    public GameObject Finder;
    public GameObject NotFind;
    public GameObject Find;



	// Update is called once per frame
	void Update () {

        if (Finder.activeInHierarchy == false)
        {
            NotFind.SetActive(false);
        }

    }
}
