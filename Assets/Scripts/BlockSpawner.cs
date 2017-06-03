using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject blockPrefab;
	public float timeBetweenWaves = 3f;

	private float timeToSpawn = 2f;

	private void SpawnBlocks(){
		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++) {
			if (i != randomIndex) {
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
			}
		}
	}

	private void Update(){
		if (Time.time > timeToSpawn) {
			SpawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}
	}

}
