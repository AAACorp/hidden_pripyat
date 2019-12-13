using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Select : MonoBehaviour {

    float Lenght = 10;
   // public int Count;
    Camera fpsCam;
   

	// Use this for initialization
	void Start () {
        fpsCam = this.GetComponent<Camera>();
	}
	


	// Update is called once per frame
	void Update () {
        Vector3 lineOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

        Vector3 EndLine = fpsCam.transform.forward * Lenght;

        Debug.DrawLine(lineOrigin, EndLine, Color.red);

        Ray R = new Ray(lineOrigin, EndLine);

        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(R,out hit,Lenght))
        {
            OnSelect MyObject = hit.collider.GetComponent<OnSelect>();
           // Timer CountObj = GetComponent<Timer>();

            if(MyObject != null)
            {

                switch(MyObject.Name)
                {
                    case "Cube":
                        if(Input.GetButtonDown("Fire1"))
                        {
                            MyObject.Visible = false;
                            //Count-= 1;
                        }
                        break;
                    case " ":
                        break;
                }
            }
 

        }

        
	}

}
