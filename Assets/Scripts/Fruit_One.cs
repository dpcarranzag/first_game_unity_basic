using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fruit_One : MonoBehaviour
{
    AudioSource sonido;
    public static int flag;
    //public static Scene scene;

    void Start()
    {
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
            countSceneOne();
            

        }

    }


    private void countSceneOne()
    {
        flag += 1;
        //Debug.Log("entreSceneOne" + flag);
        if (flag == 6)
        {

            //nextLevel.SetActive(true);
            SceneManager.LoadScene(4);

        }

    }
}
