using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int sceneNumber;
    public void Tranistion()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}