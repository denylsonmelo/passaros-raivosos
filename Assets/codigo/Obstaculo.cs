using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    int vida = 50;
    [SerializeField]
    Sprite[] imagens;

    private SpriteRenderer imagemAtual;
    [SerializeField]
    private int vidaAtual;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("executou uma vez");

        vidaAtual = vida;

        imagemAtual = GetComponent<SpriteRenderer>();
        imagemAtual.sprite = imagens[0];
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("executando a cada quadro");
        verificarVida();
    }

    void verificarVida(){
        if(vidaAtual <= (vida * 0.7)){
            imagemAtual.sprite = imagens[1];
        }
        if(vidaAtual <= (vida * 0.3)){
            imagemAtual.sprite = imagens[2];
        }
        if(vidaAtual <= 0 ){
            Debug.Log("bloco morreu");
            vidaAtual = 0;
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D batida)
    {
        if(batida.gameObject.tag == "Player"){
            Debug.Log("batida no jogador");
            vidaAtual = vidaAtual - 12;
        }
        if(batida.gameObject.tag == "chao"){
            Debug.Log("batida no chao");
            vidaAtual = vidaAtual - 5;
        }
        if(batida.gameObject.tag == "obstaculo"){
            Debug.Log("batida no obstaculo");
            vidaAtual = vidaAtual - 8;

        }
        
    }
}
