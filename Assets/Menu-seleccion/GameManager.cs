using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject defaultCharacter;
    private GameObject actualCharacter; // Mantiene el Prefab del personaje con el que se desea jugar

    public static GameManager Instance;

    public List<Personajes>personajes;

    // Start is called before the first frame update
    private void Awake()
    {
    if(GameManager.Instance == null)
    {
        GameManager.Instance = this;
        DontDestroyOnLoad(this.gameObject);

    }
    else {
        Destroy(gameObject);
    }
    }
    public static GameManager getInstance(){
        return GameManager.Instance;
    }
    ///////////////////////////////////////////////




}
