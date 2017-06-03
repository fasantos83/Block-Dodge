using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text scoreText;
	public GameObject playerPrefab;
	public float slowness = 10f;

	private int score = 0;

	private void Start(){
		Instantiate(playerPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
	}

	private void Update(){
		score = (int) Time.timeSinceLevelLoad;
		scoreText.text = "Score: " + score;
	}

	public void EndGame(){
		StartCoroutine(RestartLevel());
	}

	private IEnumerator RestartLevel(){

		// matrix effect
		Time.timeScale = 1f / slowness;
		Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

		yield return new WaitForSeconds(1f / slowness);

		// Get back to normal time
		Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
