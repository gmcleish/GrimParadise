using UnityEngine;
using System.Collections;

// this spawns things..at a certain rate
public class isSpawner : Mixin {

	public GameObject obj; //fireball, enemy, item, dont care!
    public GameObject recip;
    private Vector3 spawnPos;

    public void Spawn()
	{
        spawnPos.x = Random.Range(
            (this.gameObject.transform.position.x - this.gameObject.transform.lossyScale.x / 2), 
            (this.gameObject.transform.position.x + this.gameObject.transform.lossyScale.x / 2));

        spawnPos.z = Random.Range(
            (this.gameObject.transform.position.z - this.gameObject.transform.lossyScale.z / 2),
            (this.gameObject.transform.position.z + this.gameObject.transform.lossyScale.z / 2));

        spawnPos.y = this.gameObject.transform.position.y;

        Instantiate(obj, spawnPos, this.gameObject.transform.rotation);/// fix, add a place and rotation..
	}

    public void OnTriggerEnter()
    {
        recip = GetRecipient();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
}
