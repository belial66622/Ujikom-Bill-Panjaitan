using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ujikom.sceneloader;

namespace Ujikom.home {
    public class Home : MonoBehaviour
    {
        [SerializeField] Button _start;
        // Start is called before the first frame update
        void Start()
        {
            _start.onClick.RemoveAllListeners();
            _start.onClick.AddListener(Startgame);
        }


        void Startgame()
        {
            SceneLoader.Instance.ChangeScene("Pack");
            Debug.Log("Pack");
        }
    }
}
