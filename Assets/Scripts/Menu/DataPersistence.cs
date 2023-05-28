using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    private static DataPersistence instance;
    public string test;

    private void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If not, set the instance to this object
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this object
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleInput(string input)
    {
        // Do something with the input
        Debug.Log("Received input: " + input);
        test = input;
    }
}
