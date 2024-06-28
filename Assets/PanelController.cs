using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
    public GameObject panelBase;
    public GameObject panelInputVacio;
    public GameObject panelRespuestaCorrecta;
    public GameObject panelRespuestaIncorrecta;

    public FoodInstantiator script;
    public InputField input_Respuesta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideInputVacioPanel()
    {
        panelInputVacio.SetActive(false);
        panelBase.SetActive(true);
    }

    public void HideRespuestaIncorrectaPanel()
    {
        panelRespuestaIncorrecta.SetActive(false);
        panelBase.SetActive(true);
    }

    public void CheckAnswer()
    {
        if (input_Respuesta.text == "")
        {
            panelBase.SetActive(false);
            panelInputVacio.SetActive(true);
        }
        else if (int.Parse(input_Respuesta.text) == script.maxClones)
        {
            panelRespuestaCorrecta.SetActive(true);
            panelBase.SetActive(false);
        }
        else
        {
            panelRespuestaIncorrecta.SetActive(true);
            panelBase.SetActive(false);
        }

       
    }

    public void StartGame()
    {

    }
    public void Restart()
    {
        SceneManager.LoadScene(0);   
    }
}
