using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScreen : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ActiveScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

}
