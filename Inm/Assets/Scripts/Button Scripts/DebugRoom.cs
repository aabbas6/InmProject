using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugRoom : MonoBehaviour {

	public void startDebug()
    {
        SceneManager.LoadScene("DebugScene");        
    }
}
