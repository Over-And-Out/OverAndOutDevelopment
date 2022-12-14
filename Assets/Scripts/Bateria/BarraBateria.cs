using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraBateria : MonoBehaviour
{
    public int bateria;
    public int numOfbateria;

    public Image[] bateriasprite;
    public Sprite bateriaLlena;
    public Sprite bateriaMedioLlena;
    public Sprite bateriaMitad;
    public Sprite bateriaMedioVacia;
    public Sprite bateriaCasiVacia;
    public Sprite bateriaVacia;

    void Update(){
       
       for (int i = 0; i < bateriasprite.Length; i++){
            
            if(i = 5){
                bateriasprite[i].sprite = bateriaLlena;
            }
            if(i = 4){
                bateriasprite[i].sprite = bateriaMedioLlena;
            }
            if(i = 3){
                bateriasprite[i].sprite = bateriaMitad;
            }
            if(i = 2){
                bateriasprite[i].sprite = bateriaMedioVacia;
            }
            if(i = 1){
                bateriasprite[i].sprite = bateriaCasiVacia;
            }
            if(i = 0){
                bateriasprite[i].sprite = bateriaVacia;
            }


            if(i < numOfbateria){
                bateriasprite[i].enabled = true;
            } else {
                bateriasprite[i].enabled = false;
            }
       }
    }

}
