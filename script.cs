using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{

    public float VarSumada;

    public float ResultadoTotal;

    public Text VarSumadaDisplay;

    private void Start()
    {
        VarSumada = PlayerPrefs.GetFloat("VarSumada", VarSumada);
    }
    public void Update()
    {
        VarSumadaDisplay.text = "" + Mathf.Round(VarSumada);
    }
    public void ClickChocolate()
    {
        VarSumada += 1;
        PlayerPrefs.SetFloat("VarSumada", VarSumada);
    }
}
