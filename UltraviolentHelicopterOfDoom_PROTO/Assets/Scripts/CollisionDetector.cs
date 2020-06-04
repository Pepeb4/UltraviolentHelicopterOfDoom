using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionDetector : MonoBehaviour
{
    public GameObject endGamePanel;
    public GameObject endGamePanel2;
    //public Text gameScore;
    //public Text endScore;
    // Start is called before the first frame update
    void Start()
    {
        endGamePanel.gameObject.SetActive(false);
        endGamePanel2.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Finish")
        {
            //collision
            //endScore.text = gameScore.text;
            endGamePanel.gameObject.SetActive(true);
            //Destroy(gameObject);
        }
        if (other.gameObject.tag == "Obstacle")
        {
            //collision
            //endScore.text = gameScore.text;
            endGamePanel2.gameObject.SetActive(true);
            //Destroy(gameObject);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
