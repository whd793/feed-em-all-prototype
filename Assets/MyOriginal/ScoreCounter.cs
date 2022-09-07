using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreCounter : MonoBehaviour
{
    public GameController gameController;
        	private GameManager _game;


    private void Awake()
    {
                // _game = GameManager.Instance;

        //gameController = GameObject.FindGameObjectsWithTag("GameController").GetComponent<GameController>(); ;
    }
    // Start is called before the first frame update
    void Start()
    {
                        _game = GameManager.Instance;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            // gameController.score += 1;
            _game.levelProgression = 100;

            this.gameObject.SetActive(false);
           //Debug.Log(gameController.score);
          
        }
    }

        	
}
