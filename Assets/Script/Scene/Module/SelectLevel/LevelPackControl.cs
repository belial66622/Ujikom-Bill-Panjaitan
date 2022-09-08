using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Ujikom.Data;
using Ujikom.scriptableobject;
using Ujikom.sceneloader;

    namespace Ujikom.selectLevel {
    public class LevelPackControl : MonoBehaviour
    {
        [SerializeField] List<LevelModel> modelLevel;
        Pack[] pack;
        Button[] _button;
        string[] Namelist;
        int currentpack;
        [SerializeField] GameObject _buttonprefarb;
        // Start is called before the first frame update
       

        private void Start()
        {
            GetCurrentpack();
            LoadPackList();
            GetPacksList();
            setButton();
            DisplayButton();
        }

        void loadDetailPack()
        {

        }

        void setButton()
        {
            _button = new Button[modelLevel.Count];
        }

        void DisplayButton()
        {
            for (int i = 0; i < _button.Length; i++)
            {
                int x = i;
                GameObject temp;
                temp = Instantiate(_buttonprefarb,transform);
                temp.GetComponentInChildren<TextMeshProUGUI>().text = modelLevel[i].LevelName;
                temp.GetComponentInChildren<Button>().onClick.AddListener(delegate { ChangeScene(x); }) ;

            }

        }


        void ChangeScene(int i)
        {
            DataBaseController.Instance.SetCurrentPackID(i);
            SceneLoader.Instance.ChangeScene("Level");
        }

        void GetCurrentpack()
        {
            currentpack = DataBaseController.Instance.GetCurrentPackID();
        }
        void LoadPackList()
        {
            pack = DataBaseController.Instance.GetPackList();
        }

        void GetPacksList()
        {
            modelLevel = new() ;

            for (int i = 0; i < pack[currentpack].level.Length; i++)
            {
                modelLevel.Add(new());
                modelLevel[i].LevelName = "level " + pack[currentpack].level[i].LevelID;
                modelLevel[i].LevelID = pack[currentpack].level[i].LevelID;
                modelLevel[i].IsComplete = false;
                Debug.Log("jalan");
            }
        }



    }
}