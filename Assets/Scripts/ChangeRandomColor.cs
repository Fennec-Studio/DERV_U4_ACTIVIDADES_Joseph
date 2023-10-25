using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRandomColor : MonoBehaviour
{
    [SerializeField] float time = 1f;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(changeColor());
    }

    void Update()
    {
        
    }

    IEnumerator changeColor()
    {
        yield return new WaitForSeconds(time);
        Color color = new Color(Random.value, Random.value, Random.value);
        rend.material.color = color;
        StartCoroutine(changeColor());
    }
}
