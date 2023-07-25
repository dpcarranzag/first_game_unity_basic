using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Zero : MonoBehaviour
{
    [SerializeField] LayerMask capaSuelo;
    Rigidbody2D rb2d;
    SpriteRenderer sR;
    RaycastHit2D raycastSuelo;
    private float timeAcum = 0;
    public float velocidad = 1f;
    public float salto = 3f;
    //private bool doubleJump = true;
    private float scaleOnY = 0f;
    private Animator animator;
    bool hasJump  = false; // Bandera que indica que el personaje ha realizado el primer salto
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        rb2d = GetComponent<Rigidbody2D>();
        sR = GetComponent<SpriteRenderer>();
        scaleOnY = gameObject.transform.localScale.y*0.16f+0.04f;
        animator = GetComponent<Animator>();

    }


    void Update()
    {
        raycastSuelo = Physics2D.Raycast(transform.position, Vector2.down, scaleOnY, capaSuelo);
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        SpriteApper();
        HorizontalController();
        JumpController();
    }

    private void JumpController()
    {

        if (Input.GetKeyDown("space"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, salto);
            animator.SetBool("jump", true);
            Debug.Log("UP - enElPiso: ");
            if(hasJump){
                Debug.Log("hasjump");
                // Esto se ejecuta cuando YA HA SALTADO por primera vez
                animator.SetBool("doubleJump", true);
                hasJump  = false;
                float d_i = 1;
                if(rb2d.velocity.x < 0) d_i = -1; // ¿El personaje va para la derecha o la izquierda?
                //fuerza vertical y horizontal - como el personaje está en el aire es necesario imprimirle también fuerza horizontal
                rb2d.velocity = new Vector2(rb2d.velocity.x, salto);
            }
            else{
                // Esto se ejecuta cuando es el PRIMER SALTO
                hasJump  = true;
                animator.SetBool("jump", true);
                animator.SetBool("doubleJump", false);
                //fuerza vertical - el desplazamiento horizontal lo da la inercia que lleve el personaje
               rb2d.velocity = new Vector2(rb2d.velocity.x, salto);
            }

        }

            if (raycastSuelo == true)
            {
            Debug.Log("Raycast suelo");
                //gameObject.transform.GetChild(0);
                gameObject.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Play();
                rb2d.velocity = new Vector2(rb2d.velocity.x, salto);
 }

                // ** Detector de movimiento descendente **
        //    Sirve para cambiar la animación del personaje y como
        //    límite para realizar un segundo salto
        if(rb2d.velocity.y < -0.1){
          hasJump = false;
          animator.SetBool("jump", false);
          animator.SetBool("doubleJump", false);
        }


    }


    private void SpriteApper()
    {
        timeAcum += Time.deltaTime;
        if (timeAcum > 0.5f)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
    private void HorizontalController()
    {
        rb2d.velocity = new Vector2(Input.GetAxis("Horizontal") * velocidad, rb2d.velocity.y);
        if (Input.GetAxis("Horizontal") != 0)
        {




            if (Input.GetAxis("Horizontal") < 0)
            {

                animator.SetBool("running", true);
                sR.flipX = true;

            }
            else
            {
                animator.SetBool("running", true);
                sR.flipX = false;


            }


        }
        else{
            animator.SetBool("running", false);

        }
    }
    }


