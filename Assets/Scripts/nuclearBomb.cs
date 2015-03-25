using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class nuclearBomb : MonoBehaviour {
	public Texture2D[] images;
	public int index = 0;
	public AudioSource bomb;
	public Canvas endingScreen;
	public Text jimmyDiedText;
	public Text totalTimeLasted;
	public rageBar RageBar;
	public RawImage explosionImage;
	public Color white = new Color (255, 255, 255, 255);
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Indexer", 0, 0.1f);
		bomb.Play ();
		endingScreen = endingScreen.GetComponent<Canvas>();
		totalTimeLasted = totalTimeLasted.GetComponent<Text> ();
		jimmyDiedText = jimmyDiedText.GetComponent<Text> ();
		explosionImage = explosionImage.GetComponent<RawImage> ();
		explosionImage.color = white;
	}
	
	// Update is called once per frame
	void Update () {
		jimmyDiedText.text = "Jimmy Exploded";
		totalTimeLasted.text = "Total time survived: " + RageBar.TotalTime ();
	}

	void Indexer(){
		if (index < 108) {
			index++;
			explosionImage.texture = images [index];
		}
		if (index == 108) {
			Application.LoadLevel (Application.loadedLevel);
			Destroy(this);
		}
	}

	//void OnGUI() {
	//	GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), images[index] as Texture);
	//}
}
