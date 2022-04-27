﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;



    public class Tracker : MonoBehaviour
    {
    public GameObject Player;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
        {
        offset = transform.position - Player.transform.position;
        }

        // Update is called once per frame
        void LateUpdate()
        {
        transform.position = Player.transform.position + offset;
        }
    }
