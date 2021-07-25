using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [Header("Scene number:")]
    [SerializeField] int scene1;
    [SerializeField] int scene2;

    //SceneSwitch mogelijkheid voor op een knop
    private void SceneSwitch1()
    {
        SceneManager.LoadScene(scene1);
    }

    private void SceneSwitch2()
    {
        SceneManager.LoadScene(scene2);
    }

}
