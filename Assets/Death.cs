using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOver;
    public AudioSource Die;
    public AudioSource ping;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Die.Play();
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
        if (other.gameObject.CompareTag("ScoreBarrier"))
        {
            ping.Play();
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void mm()
    {
        SceneManager.LoadScene(0);
    }
}
