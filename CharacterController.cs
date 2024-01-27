using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f; //1
    [SerializeField] private float jumpForce = 50f; //2
    private Rigidbody2D _rigidbody2D; //4
    private Animator _animator; //9

    private bool grounded; //3
    private bool started; //7
    private bool jumping; //25

    private void Awake()//5
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); //6- caching
        _animator = GetComponent<Animator>(); //10- caching
        //started = true; //8
        grounded = true; //18
    }

    private void Update()//11
    {
        if (Input.GetKeyDown("space")) //12- Spaceye basýldýðýnda (Edit>Project Settings>Input Manager>Axes) karakter hareketi saðlansýn.
        {//Updateda sadece animasyon kullanmak sorun açabilir!

            //Debug.Log("Jumping"); //13- Tuþ kontrol amaçlý

            if (started && grounded)//14- Oyun baþladýysa//14 ve yerdeysek//19
            {
                _animator.SetTrigger("Jump"); //17
                grounded = false; //19
                jumping = true; //26
            }
            else//15
            {
                _animator.SetBool("GameStarted", true);//16
                started = true; //20
            }
        }
            _animator.SetBool("Grounded", grounded); //33

    }

    private void FixedUpdate() //21
    {
        if (started)//22
        {
            _rigidbody2D.velocity = new Vector2(speed, _rigidbody2D.velocity.y); //23
            //Rigidbody'de constrait de z rotasyonunu tikle!
        }

        if (jumping)//27
        {
            _rigidbody2D.AddForce(new Vector2(0f, jumpForce)); //28
            jumping = false;//29
        }
    }

    private void OnCollisionEnter2D(Collision2D other)//30
    {
        if(other.gameObject.CompareTag("Ground"))//31
        {
            grounded = true; //32
        }
    }
}
