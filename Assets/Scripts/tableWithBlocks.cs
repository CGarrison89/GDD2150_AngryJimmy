using UnityEngine;
using System.Collections;

public class tableWithBlocks : MonoBehaviour {
	GameObject cube5;
	public rageBar RageBar;
	bool hasRan = false;
	
	// Use this for initialization
	void Start () {
		cube5 = GameObject.Find (this.name +"/Cube 5");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hasRan == false) {
			if (cube5.transform.localPosition.z < 2.5|| cube5.transform.localPosition.z > 3.5) {
				RageBar.SubtractFive();
				hasRan = true;
			}
		}
	}
}
