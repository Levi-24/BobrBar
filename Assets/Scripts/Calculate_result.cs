using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

//2023.10.20.
//Pendroid elsõ forduló
//Ital automata feladat

//Extra funkciók:
//-grafikus megjelenítés
//- háttérzene
//- hangeffektek
//- interaktiv játék
//- saját készitésû sprite-ok

public class CalculateEredmeny : MonoBehaviour
{
    public Slider elso;
    public Slider masodik;
    public Slider harmadik;
    public TextMeshProUGUI eredmeny;
    public Button gomb;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = gomb.GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        double vegeredmeny = Math.Round(Math.PI * Math.Pow(elso.value, 2) * masodik.value * harmadik.value, 2);
        eredmeny.text = vegeredmeny.ToString() + "ml";

    }
}
