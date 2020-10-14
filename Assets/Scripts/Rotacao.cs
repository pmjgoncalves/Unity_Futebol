#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Collections;
using System.Collections.Generic;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using UnityEngine;
using UnityEngine.UI;


public class Rotacao : MonoBehaviour
{
    //Posição Seta
   [SerializeField]private Transform posStart;
    //Seta
   [SerializeField]private Image setaImg;
    //Ang
    public float zRotate;


    void Start()
    {
        PosicionaSeta();
        Posicionabola();
    }

    
    void Update()
    {
        RotacaoSeta();
        InputDeRotacao();
    }

    void PosicionaSeta()
    {
        setaImg.rectTransform.position = posStart.position;
    }
    void Posicionabola()
    {
        this.gameObject.transform.position = posStart.position;
    }

    void RotacaoSeta()
    {
        setaImg.rectTransform.eulerAngles = new Vector3(0,0,zRotate);
    }

    void InputDeRotacao()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            zRotate += 2.5f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            zRotate -= 2.5f;
        }

    }


}
