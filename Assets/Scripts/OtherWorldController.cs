using UnityEngine;
using System.Collections;

public class OtherWorldController : MonoBehaviour {

	public int Knowledge;
	public int Spirit;
	public int Technologie;

	//TODO: nice representation in UI
	//TODO: scaling the corresponding stats
	public int KnowledgeLevel = 1;
	public int SpiritLever = 1;
	public int TechnologieLevel = 1;

	public Vector2 KnowledgeRange;
	public Vector2 SpiritRange;
	public Vector2 TechnologieRange;

	public bool CanBeOwned = false;

	// Use this for initialization
	void Start () {
		Knowledge = Random.Range((int)KnowledgeRange.x, (int)KnowledgeRange.y);
		Spirit = Random.Range((int)SpiritRange.x, (int)SpiritRange.y);
		Technologie = Random.Range((int)TechnologieRange.x, (int)TechnologieRange.y);

		this.GetComponent<SpriteRenderer>().color = new Color(0.2f, 0.2f, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		if (CanBeOwned) {
			this.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
		}
	}
}
