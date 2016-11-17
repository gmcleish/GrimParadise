using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

public class LevelMgr : MonoBehaviour {

	public string LevelName;
	public bool LoadNow;
	private string curLevel;

	public void ChangeLevel()
	{
		//Application.LoadLevelAdditiveAsync(LevelName);
		if (curLevel == null) 
		{
			SceneManager.LoadSceneAsync(LevelName, LoadSceneMode.Additive);
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(LevelName));
			curLevel = LevelName;
		}
		else
		{
			SceneManager.LoadSceneAsync(LevelName, LoadSceneMode.Additive);
			SceneManager.UnloadScene(curLevel);
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(LevelName));
			curLevel = LevelName;
		}

		LoadNow = false;
	}

	public void LevelMgrUpdate()
	{
		if (LoadNow) {
			ChangeLevel();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		LevelMgrUpdate();
	}
}
