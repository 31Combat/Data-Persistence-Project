using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputSender : MonoBehaviour
{

    public DataPersistence dataPersistence; // Reference to the PersistentSingleton script
    public TextMeshProUGUI inputField; // Reference to the InputField component

    public void SendInputToSingleton()
    {
        string input = inputField.text; // Get the input from the InputField

        // Call a method in the PersistentSingleton script and pass the input as an argument
        dataPersistence.HandleInput(input);
    }
}
