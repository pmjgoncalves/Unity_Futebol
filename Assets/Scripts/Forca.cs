#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Collections;
using System.Collections.Generic;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using UnityEngine;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using UnityEngine.UI;
#pragma warning restore IDE0005 // Using directive is unnecessary.



public class Forca : MonoBehaviour
{

    private Rigidbody2D bola;
    private float force = 1000f;
    private Rotacao rot;

    void Start()
    {
        bola = GetComponent<Rigidbody2D>();
        rot = GetComponent<Rotacao>();
    }

    
    void Update()
    {
        AplicaForca();
    }

    void AplicaForca()
    {
        float x = force * Mathf.Cos(rot.zRotate * Mathf.Deg2Rad);
        float y = force * Mathf.Sin(rot.zRotate * Mathf.Deg2Rad);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            bola.AddForce(new Vector2(x, y));
        }
    }

}
