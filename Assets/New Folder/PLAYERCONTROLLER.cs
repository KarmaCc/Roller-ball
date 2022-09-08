using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Inputsystem;

public class PLAYERCONTROLLER : MonoBehaviour
{
    private Rigidbody rb;
    private float movementx;
    private float movementy;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    void Onmove(Inputvalue movementvale)
    {
      Vector2 movementVector = movementValue.Get<Vector2>();
      
        
    }
    void fixedupdate()
    {
        rb.AddForce(movementvector);
    }

}
