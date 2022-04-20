using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{

    private void OnMouseDrag()
    {
        print("Mouse Drag");
        // almacenar la posicion del mouse en un vector2
        // transformar la posicion del mouse a world posicion
        // aplicar esa posicion nueva al objeto
        Vector3 posicionMouse = Input.mousePosition;
        posicionMouse.z = 10;
        Vector3 posicionCorregida = Camera.main.ScreenToWorldPoint(posicionMouse);

        transform.position = posicionCorregida;
    }



}
