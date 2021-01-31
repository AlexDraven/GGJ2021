using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour
{
    private Light directionalLight;
    // Start is called before the first frame update
    public  float tiempoAcumulado = 0;
    private float ttt;
    void Start()
    {
        directionalLight = GetComponent<Light>();
        ttt = 5;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoAcumulado += Time.deltaTime;
        if(tiempoAcumulado > ttt)
        {
            ttt = Random.Range(1.0f, 3.0f);
            tiempoAcumulado = 0;
            Color clr = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f)
            );
            directionalLight.color = clr;
        }
        
    }
}
