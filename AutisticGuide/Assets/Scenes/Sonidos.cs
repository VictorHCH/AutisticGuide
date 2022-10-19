// Se importan las librerias a utilizar 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    // Se crean dos variables para controlar los sonidos, la primer variable almacena la fuente y la segunda el sonido 
    public AudioSource fuente;
    public AudioClip clip;

    // Se obtiene la fuente que se genera del clip
    public void Start(){
        fuente.clip = clip;
    }

    // Se reproduce el sonido que se establezca mediante el boton 
    public void DecirA(){
        fuente.Play();
    }
}
