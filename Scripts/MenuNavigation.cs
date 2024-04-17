using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoringSystem.scorePoints -= ScoringSystem.scorePoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ARScan()
    {
        SceneManager.LoadScene(1);
    }

    public void PopQuiz()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Initiate Retreat!");
    }

}
