using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMusic : MonoBehaviour
{
    Music mu;
    public GameObject on;
    public GameObject off;
    // Start is called before the first frame update
    void Start()
    {
        mu = GameObject.FindGameObjectWithTag("MainMusic").GetComponent<Music>();
        on.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reproducir() {
        mu.PlayMusic();
        on.SetActive(false);
        off.SetActive(true);
    }

    public void Parar()
    {
        mu.StopMusic();
        off.SetActive(false);
        on.SetActive(true);
        

    }

    public void pausar()
    {
            mu.PauseMusic();
    }
}
