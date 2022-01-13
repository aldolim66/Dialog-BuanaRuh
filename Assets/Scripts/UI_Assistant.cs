using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Assistant : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    [SerializeField] private Text messageText;
    [SerializeField] private float timeTyping = 0.3f;
    [SerializeField] private string[] message;

    private int index = 0;
    

    private void Update()
    {
        if(textWriter.statusDone == true)
        {
            textWriter.statusDone = false;
            textWriter.AddWriter(messageText, message[index], timeTyping);
            index++;
        }  
    }

}
