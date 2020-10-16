#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Collections;
using System.Collections.Generic;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using UnityEngine;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using UnityEngine.UI;
#pragma warning restore IDE0005 // Using directive is unnecessary.

public class Rotacao : MonoBehaviour
{

    //Posição Seta
    [SerializeField] private Transform posStart;
    //Seta
    [SerializeField] private Image setaImg;
    //Ang
    public float zRotate;
    public bool liberaRot = false;
    public bool liberaTiro = false;

    void Start()
    {
        PosicionaSeta();
        PosicionaBola();
        LimitaRotacao();
    }

    // Update is called once per frame
    void Update()
    {
        RotacaoSeta();
        InputDeRotacao();
    }

    void PosicionaSeta()
    {
        setaImg.rectTransform.position = posStart.position;
    }

    void PosicionaBola()
    {
        this.gameObject.transform.position = posStart.position;
    }

    void RotacaoSeta()
    {
        setaImg.rectTransform.eulerAngles = new Vector3(0, 0, zRotate);
    }

    void InputDeRotacao()
    {
        

#pragma warning disable CS0665 // Assignment in conditional expression is always constant
        if (liberaRot == true)
#pragma warning restore CS0665 // Assignment in conditional expression is always constant
        {
            
            float moveY = Input.GetAxis("Mouse Y");

            if (zRotate < 90)
            {
                if (moveY > 0)
                {
                    zRotate += 2.5f;
                }
            }

           if(zRotate > 0)
            {
                if (moveY < 0)
                {
                    zRotate -= 2.5f;
                }
            }

            

        }

    }

    void LimitaRotacao()
    {
        if (zRotate >= 90)
        {
            zRotate = 90;
        }

        if (zRotate <= 0)
        {
            zRotate = 0;
        }

    }

    void OnMouseDown()
    {
        liberaRot = true;
    }

    void OnMouseUp()
    {
        liberaRot = false;
        liberaTiro = true;
    }

}