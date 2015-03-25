using UnityEngine;
using System.Collections;

public class TeacherScript : MonoBehaviour {
	GameObject cube3;
	bool hasRan = false;
	public AudioSource impact;
	public rageBar RageBar;
	public Canvas teacherDown;
	
	// Use this for initialization
	void Start () {
		cube3 = GameObject.Find (this.name +"/Cube 3");
		teacherDown = teacherDown.GetComponent<Canvas> ();
		teacherDown.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hasRan == false) {
			if (cube3.transform.localPosition.y < 3.9 || cube3.transform.localPosition.y > 4.1) {
				impact.Play();
				RageBar.SubtractAll();
				teacherDown.enabled = true;
				hasRan = true;
			}
		}
	}
}
