using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;//velocidad de movimiento
    Animator anim;
    [Header("Flip")]
    bool FacingRigth;
    [Header("Jump")]
    public float jumpForce;
    Rigidbody2D TheRb;
    float axisY;
    bool IsJumping;
    [Header("ataque")]
    bool Isattacking;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        TheRb = GetComponent<Rigidbody2D>();
        TheRb.Sleep();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        anim.SetFloat("Run", Mathf.Abs(horizontal != 0 ? horizontal : vertical));


        if(horizontal < 0 && FacingRigth == false)
        {
            Flip();
        }else if(horizontal > 0 && FacingRigth == true)
        {
            Flip();
        }


        Vector3 Movement = new Vector3(horizontal * MoveSpeed, vertical * MoveSpeed, 0.0f);
        transform.position = transform.position + Movement * Time.deltaTime;
        if(transform.position.y <= axisY)
        {
            OnLanding();
        }

        if(Input.GetKeyDown(KeyCode.Space) && !IsJumping)
        {
            axisY = transform.position.y;
            IsJumping = true;
            TheRb.gravityScale = 5f;
            TheRb.WakeUp();
            TheRb.AddForce(new Vector2(transform.position.x + 7.5f, jumpForce));

            anim.SetBool("IsJumping", IsJumping);
        }



        //attaque
      /*  if (Input.GetKeyDown(KeyCode.Q))
        {

        }*/
    }
    


    void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        FacingRigth = !FacingRigth;
       
    }


    void OnLanding()
    {
        IsJumping = false;
        TheRb.gravityScale = 0f;
        TheRb.Sleep();
        axisY = transform.position.y;
        anim.SetBool("IsJumping", false);
    }

}
