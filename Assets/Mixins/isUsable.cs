using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class isUsable : Mixin
{
    // isUsable a generic
    public bool useMe;
    public List<string> OnUseCBs; // what method to call when a touch happens

    void Use()
    {
        // if something touched us that we want to respond to
        foreach (string s in OnUseCBs)
        {
            if (s != "")
                SendMessage(s);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    public void isUsableUpdate()
    {
        if (useMe)
        {
            Use();
            useMe = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        isUsableUpdate();
    }
}
