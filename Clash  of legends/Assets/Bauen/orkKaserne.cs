﻿using UnityEngine;
using System.Collections;

public class orkKaserne : MonoBehaviour {
	public GameObject elfKasernePrefab;
	public Transform spawnPoint;
	public Transform Drehung2;
	public GameObject spawnPointa;
	private spawnPoint a;
	public int abriss;	
	// Use this for initialization
	void Start () {
		a = spawnPointa.GetComponent<spawnPoint > ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (a.los4 == 2) {
			Debug.Log ("los = 2");
			abriss = a.abriss;
			Instantiate (elfKasernePrefab, new Vector3(a.c3 + 10, 0f, a.v3 ), Drehung2.rotation);
			a.bBustabe = 0;
			a.bZahl = 0;
			a.los4 = -1;
			GetComponent<Renderer> ().enabled = true;
			
			
		}
		if (a.abriss != 0) {
			if (a.abriss == abriss * 10) {
				Debug.Log ("zerstört");
				Destroy (gameObject);
			}
		}
	}
}
