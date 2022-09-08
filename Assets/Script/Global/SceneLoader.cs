using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ujikom.sceneloader
{
    public class SceneLoader : MonoBehaviour
    {
        public static SceneLoader Instance { get; private set; }
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                Instance = this;
            }

            DontDestroyOnLoad(gameObject);
        }

        public void ChangeScene(string scene)
        {
            SceneManager.LoadScene(scene);
            Debug.Log(scene);
        }
    }
}