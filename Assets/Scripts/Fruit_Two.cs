using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fruit_Two : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource sonido;
    public static int flag;
    public GameObject win;
    public GameObject subWin;

    void Start()
    {
        GameObject.FindGameObjectWithTag("MainMusic").GetComponent<Music>().StopMusic();
        sonido = GetComponent<AudioSource>();
        //GetComponent<SpriteRenderer>().enabled = true;
        //gameObject.transform.GetChild(0).gameObject.SetActive(false);
        flag = 0;
        win.GetComponent<SpriteRenderer>().enabled = false;
        subWin.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sonido.Play();
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject);
            countSceneTwo();
        }
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(flag);
    }

    private void countSceneTwo()
    {
        flag += 1;
        if (flag == 4)
        {
            win.GetComponent<SpriteRenderer>().enabled = true;
            subWin.GetComponent<SpriteRenderer>().enabled = true;

        }
        else if(flag == 5)
        {
            SceneManager.LoadScene(5);
        }

    }
}
