using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "End")
        {
            if (other.gameObject.CompareTag("Chess"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        
    }
}
