﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCamera : MonoBehaviour {

    public GameObject thirdPerson;
    public GameObject firstPerson;
    private bool change = true;


    // Use this for initialization
    void Start () {
        thirdPerson.gameObject.SetActive(true);
        firstPerson.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            change = !change;
            thirdPerson.gameObject.SetActive(change);
            firstPerson.gameObject.SetActive(!change);
        }
    }
}