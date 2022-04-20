using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjeto : MonoBehaviour
{
    public float velocidad;

    public Vector2 direccion;
    public float limiteIz;
    public float limiteDe;
    public float limiteUp;
    public float limiteDown;

    private void Update()
    {
        direccion.x = Input.GetAxisRaw("Horizontal");
        direccion.y = Input.GetAxisRaw("Vertical");
        // normalizar el vector de direccion
        transform.Translate(direccion.normalized * velocidad * Time.deltaTime);

        // confinar el espacio de movimiento
        Vector2 posicionCorregida = transform.position;

        posicionCorregida.x = Mathf.Clamp(posicionCorregida.x, limiteIz, limiteDe);
        posicionCorregida.y = Mathf.Clamp(posicionCorregida.y, limiteDown, limiteUp);

        // aplicar correccion

        transform.position = posicionCorregida;
    }

}
