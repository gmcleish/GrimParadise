using UnityEngine;
using System.Collections;

public class isStoreable : Mixin {

    public Texture2D thumbnail;

    public void Store()
    {
        isInventory[] inventories = GetRecipient().GetComponentsInChildren<isInventory>();
        foreach (isInventory inv in inventories)
        {
            if (inv.Name == Name)
            {
                inv.Add(this);
            }
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
