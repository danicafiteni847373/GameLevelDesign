using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    private Key keys;

    void Start()
    {
        keys = FindObjectOfType<Key>();

    }
    void OnTriggerEnter(Collider other)
    {
        if (keys.KeyAmount >= 1)
        {
            keys.KeyAmount -= 1;
            SceneManager.LoadScene(2);
        }

    }
}
