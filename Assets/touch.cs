using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touch : MonoBehaviour
{
    public Transform caps;
    public Rigidbody playerBody;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane") 
        {
            if (collision.gameObject.name == "Plane (1)")
            {
                Debug.Log("You win!");
                SceneManager.LoadScene("Level02");
            }
            else
            {
                transform.position = caps.position;

            }

            Debug.Log("Game over");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
