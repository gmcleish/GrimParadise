using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class isInventory : Mixin {

    public List<isStoreable> data;

    public void Add(isStoreable iss)
    {
        data.Add(iss);

        Renderer[] renderers = iss.gameObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.enabled = false;
        }

        Collider[] colliders = iss.gameObject.GetComponentsInChildren<Collider>();
        foreach (Collider c in colliders)
        {
            c.enabled = false;
        }

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
