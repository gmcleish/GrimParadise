using UnityEngine;
using System.Collections;

public class hasAnimationOverride : Mixin {

    public AnimatorOverrideController origAnim;
    public AnimatorOverrideController overideAnim;

    public void OverrideAnimator()
    {
        GameObject recip = GetRecipient();
        if (recip.GetComponentInChildren<Animator>() != null)
        {
            recip.GetComponentInChildren<Animator>().runtimeAnimatorController = overideAnim;
        }
    }
    public void SetOverrideAnim(AnimatorOverrideController anim)
    {
        overideAnim = anim;
    }

    public void SetOrigAnim(AnimatorOverrideController anim)
    {
        origAnim = anim;
    }

    public AnimatorOverrideController GetOrigAnim()
    {
        return origAnim;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}