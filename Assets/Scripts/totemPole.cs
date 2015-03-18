using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GameObject))]
public class totemPole : MonoBehaviour {
	GameObject cube4;
	public rageBar RageBar;
	bool hasRan = false;

	// Use this for initialization
	void Start () {
		cube4 = GameObject.Find (this.name +"/Cube 4");

	}
	
	// Update is called once per frame
	void Update () {
		if (hasRan == false) {
			if (cube4.transform.localPosition.y < 4) {
				RageBar.SubtractFive();
				hasRan = true;
			}
		}
	}
}
