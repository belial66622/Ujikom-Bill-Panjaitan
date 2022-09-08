using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Ujikom.Data;
using Ujikom.scriptableobject;
using Ujikom.sceneloader;

    namespace Ujikom.Gameplay {
    public class gameControl : MonoBehaviour
    {
        LevelStruct level;
        Pack[] pack;
        Button[] _button;
        string[] Namelist;
        int currentpack,currentlevel;
        [SerializeField] GameObject _buttonprefarb;
        // Start is called before the first frame update
       

        private void Start()
        {
            GetQuestion();
            LoadPackList();
            GetCurrentQuestion();
            setButton();
            DisplayButton();
        }

        void loadDetailPack()
        {

        }

        void setButton()
        {
            _button = new Button[level.choice.Length];
        }

        void DisplayButton()
        {
            for (int i = 0; i < _button.Length; i++)
            {
                int x = i;
                GameObject temp;
                temp = Instantiate(_buttonprefarb,transform);
                temp.GetComponentInChildren<TextMeshProUGUI>().text = level.choice[i];
                temp.GetComponentInChildren<Button>().onClick.AddListener(delegate { ChangeScene(x); }) ;

            }

        }


        void ChangeScene(int i)
        {
            DataBaseController.Instance.SetCurrentPackID(i);
            SceneLoader.Instance.ChangeScene("Level");
        }

        void GetQuestion()
        {
            currentpack = DataBaseController.Instance.GetCurrentPackID();
            currentlevel = DataBaseController.Instance.GetCurrentLevelID();
        }
        void LoadPackList()
        {
            pack = DataBaseController.Instance.GetPackList();
        }

        void GetCurrentQuestion()
        {
            level = new();
            level = pack[currentpack].level[currentlevel];
        }



    }
}