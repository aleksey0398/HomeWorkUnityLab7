using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{

    Button btnPlay;

    // Start is called before the first frame update
    void Start()
    {
        btnPlay = GetComponent<Button>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<AudioSource>().mute = false;
        }
    }

    private void OnMouseUp()
    {
        GetComponent<AudioSource>().mute = true;
    }
}
