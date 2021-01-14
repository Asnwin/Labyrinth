using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody _rigidbody;
    CharacterController chara;


    // Start is called before the first frame update
    void Start()
    {
        chara = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        chara.Move(movement * Time.deltaTime * speed);
        if (movement != Vector3.zero)
        {
            gameObject.transform.forward = movement;
        }
        /*if(Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 2  * speed);
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2 * speed);
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector3.back * Time.deltaTime * 2 * speed);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 2 * speed);
        }*/
    }
}