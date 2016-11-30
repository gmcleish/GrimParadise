using UnityEngine;
using System.Collections;

public class BossCtrl : MonoBehaviour {

    public Vector3 inputs;  // axis values will be stored here so we can see them change in the inspector
    public bool actionButton;

    private Animator anim;  // our animator component, with the animCtrl for the hero... but how to set this reference?

    public void OnEnable()
    {
        anim = this.gameObject.GetComponentInChildren<Animator>();
    }

    // Use this for initialization
    void Start()
    {

    }

    public void BossCtrlUpdate()
    {

        actionButton = Input.GetButtonDown("Attack");

        // animate the skinned mesh for the knight/hero based on user input
        if (anim != null)
        {
            if (actionButton == true)
                anim.SetTrigger("action");
        }
    }

    // Update is called once per frame
    void Update()
    {

        BossCtrlUpdate();
    }
}
