using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public static int lifes = 4;
    public GameObject live1;
    public GameObject live2;
    public GameObject live3;
    // Start is called before the first frame update
    void Start()
    {
        lifes = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (lifes >= 3)
        {
            live1.SetActive(false);
        }
        else if (lifes == 2)
        {
            live2.SetActive(false);
        }
        else if (lifes == 1)
        {
            live3.SetActive(false);
        }
        else if (lifes == 0)
        {

            SceneManager.LoadScene(2);
        }
    }
}
