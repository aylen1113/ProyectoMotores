using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour


{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 2000 * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 2000 * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 2000 * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 2000 * Time.deltaTime);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Kill"))
        {

            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("Goal"))
        {

            SceneManager.LoadScene(1);
        }

    }
}



    