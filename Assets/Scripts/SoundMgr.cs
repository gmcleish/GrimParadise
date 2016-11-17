using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SoundMgr : MonoBehaviour {

	public List<AudioClip> PickUpBank;
	public List<AudioClip> StepBank;
	public List<AudioClip> PwrUpBank;
	public List<AudioClip> PwrDwnBank;

	static SoundMgr This;

	public void OnEnable()
	{
		if (This == null) {
			This = this;
		}
	}

	public static SoundMgr GetThis()
	{
		return This;
	}

	public static void SoundMgrDebug()
	{
		Debug.Log("FOO!");
	}

    public void PlayPickUpSound( AudioSource asource)
	{
		// 1 this method finds a random sound in fire bank
		int randIndex = Random.Range(0, PickUpBank.Count);

		// 2 then associates it with the audiocsource
		if (asource != null) {
			asource.clip = PickUpBank[randIndex];

			// 3 play the clip via the source
			asource.Play();
		}
	}

	public void PlayStepSound( AudioSource asource)
	{
		// 1 this method finds a random sound in impact bank
		int randIndex = Random.Range(0, (StepBank.Count));

		// 2 then associates it with the audiocsource
		if (asource != null) {
			asource.clip = StepBank[randIndex];

			// 3 play the clip via the source
			asource.Play();
		}
	}

	public void PlayPwrUpSound( AudioSource asource)
	{
		// 1 this method finds a random sound in impact bank
		int randIndex = Random.Range(0, PwrUpBank.Count);

		// 2 then associates it with the audiocsource
		if (asource != null) {
			asource.clip = PwrUpBank[randIndex];

			// 3 play the clip via the source
			asource.Play();
		}
	}

    public void PlayPwrDwnSound(AudioSource asource)
    {
        // 1 this method finds a random sound in impact bank
        int randIndex = Random.Range(0, PwrDwnBank.Count);

        // 2 then associates it with the audiocsource
        if (asource != null)
        {
            asource.clip = PwrDwnBank[randIndex];

            // 3 play the clip via the source
            asource.Play();
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
