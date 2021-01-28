using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    Rigidbody rigidbody;
    public float ballSpeed = 5;
    public int score = 0;

    public Text scoreText;
    public Text winText;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(horizontal, 0, vertical);
        rigidbody.AddForce(force * ballSpeed);
    }

    private void OnTriggerEnter(Collider cube)
    {
        cube.gameObject.SetActive(false);
        score++;

        scoreText.text = "Score : " + score.ToString();

        if(score >= 8)
        {
            winText.gameObject.SetActive(true);
        }
    }
}
