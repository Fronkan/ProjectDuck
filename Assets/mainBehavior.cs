using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class mainBehavior : MonoBehaviour {
	[SerializeField]
	private Scene currentScene;
    private bool levelWin  = false;
	private int nextScene;
    public float timeToRestart = 1f;
    public float timeToVictory = 0.5f;
    private bool isDisplaying = false;
	public GameObject panel;
	public GameObject loseButton;
	public GameObject loseText;
	public GameObject winButton;
	public GameObject winText;
	public GameObject mainButton;
	public GameObject mainText;
	public GameObject mainCanvas;
	// Use this for initialization
	void Start () {
		currentScene = SceneManager.GetActiveScene();
		nextScene = currentScene.buildIndex + 1;
		mainCanvas.SetActive (true);

		panel.SetActive (false);
		loseText.SetActive (false);
		loseButton.SetActive (false);
		winText.SetActive (false);
		winButton.SetActive (false);
		mainText.SetActive (false);
		mainButton.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
        /*For debuging
		if(Input.GetKeyDown("t")){
			panel.SetActive (true);
			loseText.SetActive (true);
			loseButton.SetActive (true);
		}
		if(Input.GetKeyDown("y")){
			panel.SetActive (true);
			mainText.SetActive (true);
			mainButton.SetActive (true);
		} */
        if (Input.GetButton("Restart"))
        {
            RestartScene();
        }
        if (Input.GetButton("NextLevel") && levelWin) {
            LoadNextLevel();
        }
	}
    void ShowLoss() {
        if (!isDisplaying) {
            isDisplaying = true;
            StartCoroutine(ShowLossInternal());
        }
    }

    private IEnumerator ShowLossInternal() {
        yield return new WaitForSeconds(timeToRestart);
        panel.SetActive(true);
        loseText.SetActive(true);
        loseButton.SetActive(true);
    }

    void ShowWin() {
        if (!isDisplaying)
        {
            levelWin = true;
            isDisplaying = true;
            StartCoroutine(ShowWinInternal());
        }
    }

    private IEnumerator ShowWinInternal(){
        yield return new WaitForSeconds(timeToVictory);
        panel.SetActive(true);
        winText.SetActive(true);
        winButton.SetActive(true);
    }

	public 	void GoToMain(){
		SceneManager.LoadScene (0);
	}
	public 	void RestartScene(){
		SceneManager.LoadScene (currentScene.buildIndex);
	}
	public void LoadNextLevel(){
        Debug.Log("Next level");
		LoadNewLevel();
		SceneManager.LoadScene(nextScene);
	}

	IEnumerator LoadNewLevel(){
		float fadeTime = GameObject.Find ("_GM").GetComponent<fadeScene>().BeginFade (-1);
		yield return new WaitForSeconds (fadeTime);
	}
}
