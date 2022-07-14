using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class MoveT : MonoBehaviour
{
    public float move = 0.01f;
    public AutoMoveAndRotate a;
    public GameObject int_stop;
    public GameObject int_kolejny;
    public GameObject sternik;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-move, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(move, 0f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Zderzenie");
        enabled = false;
        a.enabled = false;
        sternik.GetComponent<Animator>().speed = 0;
        if(collision.gameObject.name == "most")
        {
            int_kolejny.SetActive(true);
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            int_stop.SetActive(true);
        } 
    }
}
