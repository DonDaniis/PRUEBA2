using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField]int health;
    [SerializeField]Transform miTransformacion;
    [SerializeField] int attack;

    void GetDamage(int damage) //funcion que daña al cubo
    {

       // miTransformacion.localScale = Vector3
       //Vector3 escalaActual = miTransformacion.localScale;
       Vector3 escalaActual = new Vector3 (1f,1f,1f);


        health -= damage; //resto el daño a la salud

       
        float finalScale = health / 100f;
        //float currentScaleX = miTransformacion.localScale.x;

        Vector3 newScale = new Vector3(finalScale,finalScale,finalScale);

        //igualamos antigua escala a escala nueva
        miTransformacion.localScale = newScale;

        //imprime frase en la consola, pudiendo citar valores
        Debug.Log("auch, me hiciste" +damage+ "de daño y me queda solo" +health+ "de salud");
    }
    [ContextMenu("Danar Personaje")] //Permite testear funciones sin Play
    void GiveDamageTest()

    
    {
        GetDamage(attack);
    }

}
