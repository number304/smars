using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float velocidad;
    public float fuerzasalto;
    private Rigidbody2D rigidBody;
    private bool mirandoDerecha = true;
    private Animator animator;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        ProcesarMovimiento();
        ProcesarSalto();
    }

    void ProcesarSalto()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector2.up *fuerzasalto, ForceMode2D.Impulse);

        }
    }
    void ProcesarMovimiento()
    {

        float inputMovimiento = Input.GetAxis("Horizontal");
        if(inputMovimiento != 0f)
        {
            animator.SetBool("isRunnig", true);
        }
        else
        {
            animator.SetBool("isRunnig", false);
        }


        rigidBody.velocity = new Vector2(inputMovimiento*velocidad, rigidBody.velocity.y);
        GestionarOrientacion(inputMovimiento);
    }

    void GestionarOrientacion(float inputMovimiento)
    {
        if((mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0))
        {
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        }
    }


}
