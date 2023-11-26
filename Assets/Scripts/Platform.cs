using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
	public int width;
	public int height;

	void Awake() {
		transform.localScale = new Vector3(width, height);
		
	}
}
