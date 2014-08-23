using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HomeWorldController : MonoBehaviour {

	public int Knowledge = 100;
	public int Spirit = 100;
	public int Technologie = 100;

	public int KnowledgeLevel = 1;
	public int SpiritLever = 1;
	public int TechnologieLevel = 1;

	public int YggdrasilGroth = 0;

	public float ViewWorldsRadius = 15f;

	public float UpdateTimer = 15.0f;
	float updateTimerRunning;

	List<GameObject> ownedWorldsList;

	// Use this for initialization
	void Start () {
		ownedWorldsList = GameObject.Find("_WorldSpawner").GetComponent<WorldSpawner>().WorldsList;
		updateTimerRunning = UpdateTimer;
	}

	void GetWorldsInRange () {
		List<GameObject> worldsList = GameObject.Find("_WorldSpawner").GetComponent<WorldSpawner>().WorldsList;
		foreach (GameObject world in worldsList) {
			if ((world.transform.position - this.transform.position).magnitude < ViewWorldsRadius) {
				world.GetComponent<OtherWorldController>().CanBeOwned = true;
			}
		}
	}
	
	// Update is called once per frame

	void Update () {
		--updateTimerRunning;
		if (updateTimerRunning < 0) {
			foreach (GameObject world in ownedWorldsList) {
				Knowledge += world.GetComponent<OtherWorldController>().Knowledge;
				Spirit += world.GetComponent<OtherWorldController>().Spirit;
				Technologie += world.GetComponent<OtherWorldController>().Technologie;
			}
			updateTimerRunning = UpdateTimer;
			Debug.Log("TICK");
			GetWorldsInRange();
		}
	}

	void OnMouseDown() {
		//TODO: Switch to world interaction mode
		Debug.Log("Interacted with HomeWorld");
	}
}
