using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_Behavior : MonoBehaviour
{
    [SerializeField]
    private string tag_out = "";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tag_out)
        {
            // Reset scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
