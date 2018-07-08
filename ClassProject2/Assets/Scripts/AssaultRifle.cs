﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Gun {

	override protected void Update() {
		base.Update ();
		//AssaultRfile has automatic fire rate
		if (Input.GetMouseButton (0) && (Time.time - lastFireTime) > fireRate) {
			lastFireTime = Time.time;
			Fire ();
		}
	}
}
