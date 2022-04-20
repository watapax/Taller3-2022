using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp = 10;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("enemigos"))
        {
            hp--;
            animator.Play("da�o");
            if(hp < 1)
            {
                print("MURIO");
            }
        }
    }
}
