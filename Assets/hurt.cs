using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class hurt : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        other.gameObject.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
