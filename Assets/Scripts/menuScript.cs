using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas mainMenu;
	public Canvas exit;
	public Canvas instructions;
	public Canvas story;
	public Canvas rageBar;
	public Button startButton;
	public Button instructionsButton;
	public Button storyButton;
	public Button exitButton;
	public Animator playAnimation;
	bool levelStarted = false;
	GameObject mainCamera;
	GameObject fpsController;
	Vector3 targetPosition;


 	// Use this for initialization
	void Start () {
		rageBar = rageBar.GetComponent<Canvas> ();
		mainMenu = mainMenu.GetComponent <Canvas> ();
		exit = exit.GetComponent<Canvas> ();
		instructions = instructions.GetComponent<Canvas> ();
		story = story.GetComponent<Canvas> ();
		startButton = startButton.GetComponent<Button> ();
		instructionsButton = instructionsButton.GetComponent<Button> ();
		storyButton = storyButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
		rageBar.enabled = false;
		exit.enabled = false;
		instructions.enabled = false;
		story.enabled = false;
		mainCamera = GameObject.Find ("Main Camera");
		fpsController = GameObject.Find ("FPSController");
		playAnimation = mainCamera.GetComponent<Animator> ();
		playAnimation.enabled = false;
		fpsController.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (levelStarted == true) {
			if (mainCamera.transform.position.z <= 169){
				fpsController.SetActive (true);
				mainCamera.SetActive (false);
				playAnimation.enabled = false;
				rageBar.enabled = true;
				rageBar.GetComponent<rageBar> ().enabled = true;
			}

		}
	}

	public void ExitPress()
	{
		exit.enabled = true;
		startButton.enabled = false;
		instructionsButton.enabled = false;
		storyButton.enabled = false;
		exitButton.enabled = false;

	}

	public void BackPress()
	{
		exit.enabled = false;
		instructions.enabled = false;
		story.enabled = false;
		startButton.enabled = true;
		instructionsButton.enabled = true;
		storyButton.enabled = true;
		exitButton.enabled = true;
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

	public void StartLevel()
	{
		levelStarted = true;
		mainMenu.enabled = false;
		playAnimation.enabled = true;
		instructions.enabled = false;
		startButton.enabled = false;
		instructionsButton.enabled = false;
		storyButton.enabled = false;
		exitButton.enabled = false;
	}

	public void InstructionsPress()
	{
		instructions.enabled = true;
		startButton.enabled = false;
		instructionsButton.enabled = false;
		storyButton.enabled = false;
		exitButton.enabled = false;
	}

	public void StoryPress()
	{
		story.enabled = true;
		startButton.enabled = false;
		instructionsButton.enabled = false;
		storyButton.enabled = false;
		exitButton.enabled = false;
	}

}
