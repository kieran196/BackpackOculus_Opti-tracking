﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptiTrackHmdTranslation : MonoBehaviour
{

	public Transform translation;
	public bool invertTranslation;
	public bool disableOculusTracking;

	private void Start() {
		if (disableOculusTracking) {
			UnityEngine.XR.InputTracking.disablePositionalTracking = true;
		}
	}

	// Update is called once per frame
	void Update() {
		Vector3 pos = translation.position;
		this.transform.position = invertTranslation ? new Vector3(-pos.x, pos.y, -pos.z) : pos;
    }
}