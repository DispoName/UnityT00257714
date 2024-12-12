using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{   
    public float score;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            score += 1 * Time.deltaTime * 2;
            scoreText.SetText("Score:" + score);
    }
}
