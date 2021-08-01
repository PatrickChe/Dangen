using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public bool facingRight;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
       

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

        }

        animator.SetFloat("Speed", change.x);
        animator.SetFloat("Speed", change.y);
        animator.SetFloat("Speed", change.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
        }
    }
    void MoveCharacter()
    {
        myRigidbody.MovePosition(
        transform.position + (change * speed * Time.deltaTime));

    }
    void Slash()
    {
        animator.SetTrigger("Slash");
    }

    void Bomb()
    {

    }
}
