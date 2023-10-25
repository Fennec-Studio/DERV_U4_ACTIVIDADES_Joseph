using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessagesManager : MonoBehaviour
{
    [SerializeField] InputField tMensaje;
    [SerializeField] TextMeshProUGUI lblMensaje;
    List<string> messages = new List<string>();
    private int idx;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Insert))
        {
            messages.Add(tMensaje.text);
            lblMensaje.text = tMensaje.text;
            tMensaje.text = "";
            idx = 0;
            string msgsList = string.Join(", ", messages);
            Debug.Log(msgsList);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(idx > 0)
            {
                idx--;
                lblMensaje.text = messages[idx].ToString();
            } 
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (idx < messages.Count - 1)
            {
                idx++;
                lblMensaje.text = messages[idx].ToString();
            }
        }
    }
}
