using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("executou uma vez");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("executando a cada quadro");
    }

    void OnCollisionEnter2D(Collision2D batida)
    {
        if(batida.gameObject.tag == "Player"){
            Debug.Log("batida no jogador");
        }
        if(batida.gameObject.tag == "chao"){
            Debug.Log("batida no chao");
        }
        if(batida.gameObject.tag == "obstaculo"){
            Debug.Log("batida no obstaculo");
        }
        
    }
}
