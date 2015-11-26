﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectsTimer : MonoBehaviour {

    private float timerSpawnObject = 5.0f;
    public static int randomObject;
	public List<GameObject> prefabs = new List<GameObject>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        timerSpawnObject -= Time.deltaTime;
        if (timerSpawnObject <= 0)
        {
            timerSpawnObject = Random.Range(5, 10);
            randomObject = Random.Range(0,6);
			GameObject novo = Instantiate(prefabs[randomObject], new Vector3(7.54f, -1.38f, 0f),Quaternion.identity) as GameObject;
			novo.AddComponent<ObjectsMove>();
		}
     
            print(timerSpawnObject + " / " + randomObject);
	}
}
