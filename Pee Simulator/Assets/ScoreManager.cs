using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public Text score;
    public float scoreMult = 1;
    private float points = 0;

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        points += scoreMult * Time.deltaTime;
        score.text = "Score: " + Mathf.Round(points);
	}
}
