using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rageBar : MonoBehaviour {

	public float rageBarAmount = 0;
	public float totalTimeLasted = 0;
	public float rageBarLocation;
	public float rageBarInitialLocation = 0;
	public Image rageBarImage;
	public Text rageBarText;
	public Text totalTimeLastedText;
	GameObject nuclearExplosion;
	Vector3 position = new Vector3(0, 0, 0);


	// Use this for initialization
	void Start () {
		rageBarImage = rageBarImage.GetComponent<Image> ();
		rageBarText = rageBarText.GetComponent<Text> ();
		totalTimeLastedText = totalTimeLastedText.GetComponent<Text> ();
		InvokeRepeating ("AddOne", 0f, .5f);
		InvokeRepeating ("AddSecond", 0f, 1f);
		nuclearExplosion = GameObject.Find ("NuclearExplosion");
	}
	
	// Update is called once per frame
	void Update () {
		if (rageBarAmount == 100) {
			CancelInvoke ();
			nuclearExplosion.GetComponent<nuclearBomb> ().enabled = true;
			rageBarAmount = rageBarAmount + 1;
		} else if (rageBarAmount == -1) {
			CancelInvoke ();
		}
	}


	void AddOne()
	{
		rageBarAmount = rageBarAmount + 1;
		position.x = rageBarInitialLocation + rageBarAmount * 3.63f;
		rageBarText.text = "Rage: " + rageBarAmount;
		rageBarImage.transform.localPosition = position;
	}

	void AddSecond()
	{
		totalTimeLasted = totalTimeLasted + 1;
		totalTimeLastedText.text = "Time: " + totalTimeLasted;
	}

	public void SubtractFive()
	{
		if (rageBarAmount >= 5) {
			rageBarAmount = rageBarAmount - 5;
		} else if (rageBarAmount < 5) {
			rageBarAmount = 0;
		}
		position.x = rageBarInitialLocation + rageBarAmount * 3.63f;
		rageBarText.text = "Rage: " + rageBarAmount;
		rageBarImage.transform.localPosition = position;
	}

	public void SubtractAll()
	{
		rageBarAmount = -1;
		position.x = rageBarInitialLocation + (rageBarAmount + 1) * 3.63f;
		rageBarText.text = "Rage: " + (rageBarAmount + 1);
		rageBarImage.transform.localPosition = position;
	}

	public float TotalTime(){
		return totalTimeLasted;
	}

}
