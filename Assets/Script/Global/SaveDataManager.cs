using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ujikom.SaveData
{
    public class SaveDataManager : MonoBehaviour
    {
        [SerializeField] SaveData _savedata;

        public SaveDataManager Instance { get; private set; }

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



        void Load()
        {

        }


        void Save()
        {

        }
    }
}