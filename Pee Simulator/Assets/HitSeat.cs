using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HitSeat : MonoBehaviour {

    public Text missesText;
    public Text scoreText;
    public Text endScoreText;
    public GameObject gameOver;
    public float scoreMult = 1;
    public float misses = 100;
    private float points = 0;
    
	
	// Update is called once per frame
	void Update () {
        if (!gameOver.activeInHierarchy)
        {
            points += scoreMult * Time.deltaTime;
            scoreText.text = "Score: " + Mathf.Round(points);
        }
        
    }

    void OnParticleCollision(GameObject other)
    {
        if (misses < 1)
        {
            gameOver.SetActive(true);
            endScoreText.text = "You lasted " + Mathf.Round(points) + " seconds in the ring. weak.";
        }
        else
        {
            missesText.text = "Misses: " + misses--;
        }        
    }
}
