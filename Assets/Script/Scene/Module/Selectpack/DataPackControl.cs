using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Ujikom.Data;
using Ujikom.scriptableobject;
using Ujikom.sceneloader;

    namespace Ujikom.selectpack {
    public class DataPackControl : MonoBehaviour
    {
        [SerializeField] List<PackModel> modelPack;
        Pack[] pack;
        Button[] _button;
        string[] Namelist;
        [SerializeField] GameObject _buttonprefarb;
        // Start is called before the first frame update
       

        private void Start()
        {
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
            _button = new Button[modelPack.Count];
        }

        void DisplayButton()
        {
            for (int i = 0; i < _button.Length; i++)
            {
                int x = i;
                GameObject temp;
                temp = Instantiate(_buttonprefarb,transform);
                temp.GetComponentInChildren<TextMeshProUGUI>().text = modelPack[i].Packname;
                temp.GetComponentInChildren<Button>().onClick.AddListener(delegate { ChangeScene(x); }) ;

            }

        }


        void ChangeScene(int i)
        {
            Debug.Log(i);
            DataBaseController.Instance.SetCurrentPackID(i);
            SceneLoader.Instance.ChangeScene("Level");
        }

        void LoadPackList()
        {
            pack = DataBaseController.Instance.GetPackList();
        }

        void GetPacksList()
        {
            modelPack = new() ;

            for (int i = 0; i < pack.Length; i++)
            {
                modelPack.Add(new());
                modelPack[i].Packname = pack[i].Packname;
                modelPack[i].PackID = pack[i].PackID;
                modelPack[i].IsUnlocked = pack[i].IsUnlocked;
                modelPack[i].IsComplete = pack[i].IsComplete;
                modelPack[i].UnlockCost = pack[i].UnlockCost;
                Debug.Log("jalan");
            }
        }

        void InitPackList(PackModel[] a)
        {
           

        }

    }
}