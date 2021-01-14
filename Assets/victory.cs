using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victory : MonoBehaviour
{
    public GameObject panel;
    public bool win;
    public int cooldown;
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Win(panel);
        cooldown = 1;
        SceneManager.LoadScene("Menu");
    }
    public void Win(GameObject panel)
    {
        panel.SetActive(true);
    }
}
