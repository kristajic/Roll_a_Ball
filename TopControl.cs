using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopControl : MonoBehaviour
{
    Rigidbody physc;
    public int speed;
    public int Toplanacakobjesayisi;
    public Text scoreText;
    public Text complatedText;
    int point = 0;
    void Start()
    {
        physc = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(yatay,0,dikey);

        physc.AddForce(vector*speed);
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "engel")
        {
            other.gameObject.SetActive(false);
            point++;

            scoreText.text = "Score: " + point;

            if (point == Toplanacakobjesayisi)
            {
                complatedText.text = "Complated";
            }

        }
       

    }
}
