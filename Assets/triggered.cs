using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class triggered : MonoBehaviour {

    public GameObject b;

    public void Enter()
    {
        //b.transform.position = new Vector3(1.760959f, 0.674953f, -3.658229f);
        b.transform.position += Vector3.up * 0.02f;
    }

    public void Exit()
    {
        //b.transform.position = new Vector3(1.760959f, 0.674953f, -3.658229f);
        b.transform.position -= Vector3.up * 0.02f;
    }

}
