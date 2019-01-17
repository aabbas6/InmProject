using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextArea : MonoBehaviour {

	public void nextArea(int index)
    {
        SceneManager.LoadScene(index);
    }
}
