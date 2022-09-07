using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // public Text scoreText;
    private int m_score = 0;

    public int score
    {
        get { return m_score; }
        set {
         
            m_score = value;
            // scoreText.text = m_score.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
