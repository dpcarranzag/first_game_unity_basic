using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tramp : MonoBehaviour
{

    public static int lifes;
    public GameObject live3;
    public GameObject live2;
    public GameObject live1;
    // Start is called before the first frame update
    void Start()
    {
        lifes = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(lifes);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            lifes -= 1;
            //Scene scene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(scene.buildIndex);
            Debug.Log("muere");
            if (lifes == 3)
            {
                live3.SetActive(false);
            }
            else if (lifes == 2)
            {
                live2.SetActive(false);
            }
            else if (lifes == 1)
            {
                live1.SetActive(false);
            }
            else if (lifes == 0)
            {

                SceneManager.LoadScene(2);
            }
        }
        
    }

}
