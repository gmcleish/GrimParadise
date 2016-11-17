using UnityEngine;
using System.Collections.Generic;

public class SpawnMgr : MonoBehaviour
{
    public List<GameObject> spawnObjs;    // the prefab for the bullet we will spawn
    public List<GameObject> spawnLocs;
    private GameObject curSpawnLoc;
    private isSpawner iss;

    public AudioSource asource;
    private SoundMgr smgr;

    public float minSpawnTime;
    public float maxSpawnTime;
    private float time;
    private float spawnTime;

    public void SpawnUpdate()
    {
        time += Time.deltaTime;

        Debug.Log("Time: " + time);
        Debug.Log("Spawn Time: " + spawnTime);
        Debug.Log("Spawner: " + curSpawnLoc.name);

        if (time >= spawnTime)
        {
            if (iss.recip != null)
            {
                // if the player is not in the trigger
                if (iss.recip.GetComponentInChildren<isPlayer>() == null)
                {
                    iss.Spawn();

                    time = 0.0f;
                    SetRandomSpawnLoc();
                    SetRandomTime();
                }
            }
            else
            {
                iss.Spawn();

                time = 0.0f;
                SetRandomSpawnLoc();
                SetRandomTime();
            }
        }
    }

    public void SetRandomTime()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    public void SetRandomSpawnLoc()
    {
        curSpawnLoc = spawnLocs[Random.Range(0, spawnLocs.Count)];

        iss = curSpawnLoc.GetComponent<isSpawner>();
    }

    void OnEnable()
    {
        time = 0.0f;
        SetRandomSpawnLoc();
        SetRandomTime();
    }

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        SpawnUpdate();
    }
}
