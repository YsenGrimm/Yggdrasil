using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldSpawner : MonoBehaviour {

	public GameObject World;
	public float DensityRadius = 6.0f;
	public int Count = 10;
	public Rect WorldSize = new Rect(-100, -100, 200, 200);

	List<GameObject> worldList = new List<GameObject>();

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Count; ++i) {

			int randX = Random.Range((int)WorldSize.x, (int)(WorldSize.x + WorldSize.width));
			int randY = Random.Range((int)WorldSize.y, (int)(WorldSize.y + WorldSize.height));

			GameObject instWorld = GameObject.Instantiate(World) as GameObject;
			instWorld.transform.position = new Vector3(randX, randY, 0);

			// TODO: if space gets to messy, check here
			/*
			foreach (GameObject w in worldList) {
				Vector2 wPos = new Vector2(w.transform.position.x, w.transform.position.y);
				Vector2 instPos = new Vector2(randX, randY);

				if ((wPos - instPos).magnitude < DensityRadius) {
					break;
				} else {

					worldList.Add(instWorld);
				}
			}
			*/
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
