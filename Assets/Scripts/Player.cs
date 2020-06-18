using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //3.55,-3.7
    private Animation thisAnimation;
    private Rigidbody thisrigidbody;
    public float forceY = 0;
    public Text Scoretxt;
    public float score;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        thisrigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float ClampY = Mathf.Clamp(transform.position.y, -3.7f, 3.55f);
        transform.position = new Vector3(0, ClampY, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisrigidbody.AddForce(transform.up * forceY);
            thisAnimation.Play();
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "obstacle")
        {
            SceneManager.LoadScene("GameoverScene");
        }
        if(other.tag == "ground")
        {
            SceneManager.LoadScene("GameoverScene");
        }

        if(other.gameObject.tag == "Score")
        {
            score++;
            Scoretxt.text = "Score : " + score;
        }
    }
}
