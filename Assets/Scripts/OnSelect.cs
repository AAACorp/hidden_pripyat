using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelect : MonoBehaviour {

    public string Name = "Cube";
    public bool Visible = true;
    //List<Dobject> Objects;

    //void Start()
    //{
    //    Objects = new List<Dobject>();
    //    for (int i = 0; i <= 12; i++)
    //    {
    //        Dobject object_i = new Dobject();
    //        Objects.Add(object_i);
            
    //    }
    //    print(Objects);
    //}


    // Update is called once per frame
    void Update() {
        if (Visible == false)
        {
            this.gameObject.SetActive(false);
        }
    }

    //public struct Dobject
    //{
    //    public GameObject name1;
    //}

}
