using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerLife : MonoBehaviour
{
    Image imgVida;
    float vida = 1.0f;
    float damage;
    void Start()
    {
        imgVida = GameObject.Find("Life").GetComponent<Image>();
        vida = 1;
        imgVida.fillAmount = vida;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            //0 - Click izquierdo
            //1 - Click derecho
            //2 - Botón medio
            damage = Random.Range(0f, 1f);

            vida -= damage;
            imgVida.fillAmount = vida;

        }
    }
}
