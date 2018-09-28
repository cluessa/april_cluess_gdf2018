using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private float x;
    private float y;
    Rigidbody2D rb;//private
    public float speed;
    public int count;
    public int nbPickups;
    public Text countText;

    //Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = count + 1;
        countText.text = "Counter: " + count;
    }
    // Update is called once per frame
    void Update()
    {
        var y = Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f;
        var x = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Translate(0, x, 0);
        transform.Translate(y, 0, 0);

    }

    private void OnTriggerEnter2D(Collider2D other){
    //check to see what the player hit

    other.CompareTag("PickUp");
            {
                //print("hit pickup");
                other.gameObject.SetActive(false);
                count = count - 1;
                if (count == 0)
                {
                    print("Game over, all objects collected");
                speed = 0;
                }

                {

            }

        }
    }
}

