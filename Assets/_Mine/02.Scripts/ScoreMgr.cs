using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMgr : MonoBehaviour {

    public static ScoreMgr instance = null;
    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public int score = 0;
    public Text textScore;

	// Update is called once per frame
	void Update () {
        textScore.text = "" + score;
	}



}
