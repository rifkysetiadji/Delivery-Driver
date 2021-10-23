using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float bootsSpeed= 30f;
    [SerializeField] float slowSpeed= 15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount= Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount= Input.GetAxis("Vertical")  * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boots Up"){
            Debug.Log("Car Boots up");
            moveSpeed=bootsSpeed;
             Destroy(other.gameObject,0.05f);
        }
        if(other.tag == "Slow Down"){
            Debug.Log("Car Slow Down");
            moveSpeed=slowSpeed;
             Destroy(other.gameObject,0.05f);

        }
    }
}
