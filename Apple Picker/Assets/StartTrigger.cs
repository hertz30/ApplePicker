using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartingScript : MonoBehaviour
{
    void Update(){
    KeyCode startKey = KeyCode.Space;
    if(Input.GetKeyDown(startKey)) {
            SceneManager.LoadScene("_Scene_0");
        }
    
    }
}
