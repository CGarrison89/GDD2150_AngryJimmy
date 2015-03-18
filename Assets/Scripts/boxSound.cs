using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class boxSound : MonoBehaviour {
	
	public AudioSource impact;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Floor") {
			impact.Play();
		}
	}
}
