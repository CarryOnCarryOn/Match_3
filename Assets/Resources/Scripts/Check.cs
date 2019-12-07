using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour {

    public GameObject[] mGems = new GameObject[6];
    public GameObject CreateGem()
    {
        int num = Random.Range(0, 5);
        GameObject gem = Instantiate(mGems[num]);
        return gem;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.childCount==0)
        {
            GameObject sonGems = CreateGem();
            sonGems.transform.parent=transform;
            sonGems.transform.position = transform.position;

        }
    }
}
