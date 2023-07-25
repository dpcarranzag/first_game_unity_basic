using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Music sound;
    int scene;
    void Start()
    {
        
        scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 0 || scene == 5 || scene == 6)
        {
            GameObject.FindGameObjectWithTag("MainMusic").GetComponent<Music>();
        }


    }


    void Update()
    {
    }

    public void init() {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif

    }

    public void LevelOne()
    {
        SceneManager.LoadScene(2);
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene(3);
    }

    public void LevelThree()
    {
        SceneManager.LoadScene(4);
    }
}
