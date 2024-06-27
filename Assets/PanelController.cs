using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HideInputVacioPanel()
    {
        panelInputVacio.SetActive(false);
        panelBase.SetActive(true);
    }

    private void HideRespuestaIncorrectaPanel()
    {
        panelRespuestaIncorrecta.SetActive(false);
        panelBase.SetActive(true);
    }

    private void CheckAnswer()
    {
        /*
        if (panelBase.input_Respuesta.text == script.maxClones)
        {
            panelRespuestaCorrecta.SetActive(true);
            panelBase.SetActive(false);
        }
        else if (panelBase.input_Respuesta.text == "")
        {
            panelBase.SetActive(false);
            panelInputVacio.SetActive(true);
        } 
        else
        {
            panelRespuestaIncorrecta.SetActive(true);
            panelBase.SetActive(false);
        }

       */
    }

    private void StartGame()
    {

    }
    public void Restart()
    {
        SceneManager.LoadScene(0);   
    }
}
