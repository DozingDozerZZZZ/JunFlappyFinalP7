using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject gameOvertext;
    public bool gameOver = false;
    public static GameControl instance;
    public float scrollSpeed = -1.5f;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdDied()
    {
        gameOvertext.SetActive(true);
        gameOver = true;
    }
}
