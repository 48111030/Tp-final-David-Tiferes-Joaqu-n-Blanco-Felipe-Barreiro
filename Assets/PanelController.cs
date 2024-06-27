using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject panelBase;
    public GameObject panelInputVacio;
    public GameObject panelRespuestaCorrecta;
    public GameObject panelRespuestaIncorrecta;

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
    }
}
