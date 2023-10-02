using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Cube;
    
    public void onClick()
    {
        if (Sphere.activeSelf)
        {
            //Прячем фигуры
            Sphere.SetActive(false);

            Cube.SetActive(false);
        }
        else
        {
            //Показываем фигуры
            Sphere.SetActive(true);

            Cube.SetActive(true);
        }
    }
}
