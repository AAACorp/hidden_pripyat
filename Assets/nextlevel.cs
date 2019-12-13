using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel : MonoBehaviour {

    int i = 3;
    public GameObject player;
    public GameObject teleporter, teleporter1, teleporter2, teleporter3;
    float tpx,tpz, tpx1, tpz1, tpx2, tpz2, tpx3, tpz3;

    void Start()
    {
        tpx = teleporter.transform.position.x;
        tpz = teleporter.transform.position.z;

        tpx1 = teleporter1.transform.position.x;
        tpz1 = teleporter1.transform.position.z;

        tpx2 = teleporter2.transform.position.x;
        tpz2 = teleporter2.transform.position.z;

        tpx3 = teleporter3.transform.position.x;
        tpz3 = teleporter3.transform.position.z;
    }

    public void nextlvl()
    {
        Application.LoadLevel(i+1);
    }

    public void startgame()
    {
        Application.LoadLevel(3);
    }

    public void menu()
    {
        Application.LoadLevel(0);
    }

    public void Teleport()
    {
        player.transform.localPosition = new Vector3(tpx, player.transform.position.y, tpz);
    }
    public void Teleport1()
    {
        player.transform.localPosition = new Vector3(tpx1, player.transform.position.y, tpz1);
    }
    public void Teleport2()
    {
        player.transform.position = new Vector3(tpx2, player.transform.position.y, tpz2);
    }
    public void Teleport3()
    {
        player.transform.position = new Vector3(tpx3, player.transform.position.y, tpz3);
    }
}
