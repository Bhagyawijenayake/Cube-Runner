using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    public static int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;
    

    public GameOverScreen GameOverScreen;
    int maxScore =0;

    public void GameOver()
    {
        GameOverScreen.Setup(maxScore);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            float waitTiime = Random.Range(0.7f, 2f);

            yield return new WaitForSeconds(waitTiime);

            Instantiate(obstacle,spawnPoint.position,Quaternion.identity);
        }
    }

    void scoreUP()
    {
        score++;
        scoreText.text = score.ToString();
        
        
    }

    public void GameStart()
    {
        player.SetActive(true);
        playButton.SetActive(false);
        StartCoroutine("SpawnObstacle");
        InvokeRepeating("scoreUP",2f,1f);
    }
    
}
