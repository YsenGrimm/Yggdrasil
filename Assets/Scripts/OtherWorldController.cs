using UnityEngine;
using System.Collections;

public class OtherWorldController : MonoBehaviour {

	public int Knowledge;
	public int Spirit;
	public int Technologie;

	public int KnowledgeLeve = 1;
	public int SpiritLever = 1;
	public int TechnologieLevel = 1;

	public Vector2 KnowledgeRange;
	public Vector2 SpiritRange;
	public Vector2 TechnologieRange;

	// Use this for initialization
	void Start () {
		Knowledge = Random.Range((int)KnowledgeRange.x, (int)KnowledgeRange.y);
		Spirit = Random.Range((int)SpiritRange.x, (int)SpiritRange.y);
		Technologie = Random.Range((int)TechnologieRange.x, (int)TechnologieRange.y);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
