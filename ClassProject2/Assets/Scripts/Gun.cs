﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public float fireRate;
	protected float lastFireTime;
	public Ammo ammo;
	public AudioClip liveFire;
	public AudioClip dryFire;

	// Use this for initialization
	void Start () {
		lastFireTime = Time.time - 10;
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		
	}

	protected void Fire() {
		if (ammo.HasAmmo (tag)) {
			GetComponent<AudioSource> ().PlayOneShot (liveFire);
			ammo.ConsumeAmmo (tag);
		}
		else {
			GetComponent<AudioSource> ().PlayOneShot (dryFire);
		}

		GetComponentInChildren<Animator> ().Play ("Fire");

	}
}