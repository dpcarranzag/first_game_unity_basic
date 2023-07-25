using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private string instanceName;
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (!_audioSource.isPlaying)
            _audioSource.Play();
    }
    public void StopMusic()
    {
        _audioSource.Stop();
    }
    
    void Start()
    {
        PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForDuplicateInstances();
    }

    void CheckForDuplicateInstances()
    {
        // cache all objects containing this component
        Music[] collection = FindObjectsOfType<Music>();

        // iterate through the objects with this component, deleting those with matching identifiers
        foreach (Music obj in collection)
        {
            if (obj != this) // avoid deleting the object running this check
            {
                if (obj.instanceName == instanceName)
                {
                    DestroyImmediate(obj.gameObject);
                }
            }
        }
    }


}
