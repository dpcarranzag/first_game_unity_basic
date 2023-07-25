using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitZero: MonoBehaviour
{
    AudioSource sonido;
    public static int flag;
    //public GameObject nextLevel;
    //public static Scene scene;
    //Music sound;
    void Start()
    {
        //sound.StopMusic();
        GameObject.FindGameObjectWithTag("MainMusic").GetComponent<Music>().StopMusic();
        sonido = GetComponent<AudioSource>();
        //GetComponent<SpriteRenderer>().enabled = true;
        //gameObject.transform.GetChild(0).gameObject.SetActive(false);
       //scene = SceneManager.GetActiveScene();
        flag = 0;

    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            
            sonido.Play();
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject);
            countSceneZero();

        }
        
    }

    private void countSceneZero()
    {
        flag += 1;

        if (flag == 3)
        {
            SceneManager.LoadScene(3);

        }

    }


}
