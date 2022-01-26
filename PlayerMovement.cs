using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust;
    public float jumpForce;
    bool allow = true;
    public float max_Speed;
    public int score;
    string tekst;
    void Start()
    {
        //tekst = GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>().text;
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("w") && GetComponent<Rigidbody>().velocity.z < max_Speed)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0 ,0, m_Thrust), ForceMode.Impulse);
        }
        if (Input.GetKey("s") && GetComponent<Rigidbody>().velocity.z > -max_Speed)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0 ,0, -(m_Thrust)), ForceMode.Impulse);
        }
        if (Input.GetKey("a") && GetComponent<Rigidbody>().velocity.x > -max_Speed)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-(m_Thrust) ,0, 0), ForceMode.Impulse);
        }
        if (Input.GetKey("d") && GetComponent<Rigidbody>().velocity.x < max_Speed)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(m_Thrust ,0, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown("space") && allow == true){
            GetComponent<Rigidbody>().AddForce(new Vector3(0 ,jumpForce, 0), ForceMode.Impulse);
            allow = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        allow = true;
        if(collision.gameObject.tag == "Points")
        {
            //This is example
            score += 1;
            GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
            Debug.Log("Hit Object");
            Destroy(collision.gameObject);
            //code your thing here
            if(score == 7){
                transform.position = new Vector3(16f,750f,1039f);
            }
            else if(score == 8){
                Application.Quit();
            }

        }
    }
    void OnTriggerEnter(Collider other){
        max_Speed = 20;
        m_Thrust = 0.25f;
        if(other.gameObject.name == "Checkpoint"){
            transform.position = new Vector3(16f,750f,1039f);
        }
        else if(other.gameObject.name == "Checkpoint2"){
            transform.position = new Vector3(0f,0.375f,-7.38f);
        }
    }
    void OnTriggerExit(Collider other){
        max_Speed = 5;
        m_Thrust = 0.18f;
    }
}
