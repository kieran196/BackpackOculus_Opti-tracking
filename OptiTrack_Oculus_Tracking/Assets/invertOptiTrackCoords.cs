using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invertOptiTrackCoords : MonoBehaviour
{

	public Transform coordinates;

    // Update is called once per frame
    void Update()
    {
		this.transform.position = new Vector3(-coordinates.position.x, coordinates.position.y, -coordinates.position.z);
    }
}
