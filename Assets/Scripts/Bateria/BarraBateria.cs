using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraBateria : MonoBehaviour
{
    public static barrabateria instance;
    public int numOfbateria;

    public Image[] bateria;
    public Sprite bateriaLlena;
    public Sprite bateriaMedioLlena;
    public Sprite bateriaMitad;
    public Sprite bateriaMedioVacia;
    public Sprite bateriaCasiVacia;
    public Sprite bateriaVacia;

    void Update(){

    if(barrabateria > numOfbateria){
        barrabateria = numOfbateria;
    }

    for(int i = 0; i < barrabateria.Lenght; i++){
        
    if(i < barrabateria){
        bateria[i].sprite = bateriaLlena;
    }
        

    }
   }

    


}
