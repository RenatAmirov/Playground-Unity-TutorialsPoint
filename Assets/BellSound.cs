using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellSound : MonoBehaviour
{
    AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked!");
        mySource.Play();
    }
}
