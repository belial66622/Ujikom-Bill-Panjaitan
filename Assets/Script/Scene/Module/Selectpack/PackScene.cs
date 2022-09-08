using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ujikom.sceneloader;

namespace Ujikom.PackScene
{
    public class PackScene : MonoBehaviour
    {
        [SerializeField] Button _back;
        [SerializeField] TextMeshProUGUI text;



        private void OnEnable()
        {
            _back.onClick.AddListener(ChangeScene);

        }

        void ChangeScene()
        {
            Debug.Log("Pack");
            SceneLoader.Instance.ChangeScene("Home");
        }
    }
}