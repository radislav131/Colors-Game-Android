using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
    
{
    public Sprite layer_blue, layer_red;
    public GameObject m_on, m_off;

    void Start()
    {   if (gameObject.name == "Music")
        {
            if (PlayerPrefs.GetString("Music") == "no")
            {
                m_on.SetActive(false);
                m_off.SetActive(true);
            }
            else
            {
                m_on.SetActive(true);
                m_off.SetActive(false);
            }
        }
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_red;
        
    }
    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_blue;
        
    }  
    void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GetComponent<AudioSource>().Play();
        switch (gameObject.name)
    {
            case "Play":
                Application.LoadLevel("play");
                break;
            case "Raiting":
                Application.OpenURL("http://google.com");
                break;
            case "Home":
                Application.LoadLevel("gfgf");
                break;
            case "How TO":
                Application.LoadLevel("HowTo");
                break;
            case "Close":
                Application.LoadLevel("gfgf");
                break;
            case "Music":
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    PlayerPrefs.SetString("Music", "no");
                    m_on.SetActive(false);
                    m_off.SetActive(true);
                }

                else
                {
                    PlayerPrefs.SetString("Music", "yes");
                    m_on.SetActive(true);
                    m_off.SetActive(false);
                }
                break;



    }
    }
    }