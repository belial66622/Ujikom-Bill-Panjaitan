using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ujikom.scriptableobject;
using Ujikom.selectpack;

namespace Ujikom.Data
{
    public class DataBaseController : MonoBehaviour
    {
        LevelStruct level;
        [SerializeField] DataPack data;
        [SerializeField] Pack[] _pack;
        int _currentPack;
        int _currentLevel;
        public static DataBaseController Instance { get; private set; }

        public DataPack Data => data;
        public Pack[] Pack => _pack;

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
            if (_pack == null)
                GetPackList();
        }



        public Pack[] GetPackList()
        {
            return _pack = data.GetPack();
        }

        public string[] GetLevelList(string[] _packID)
        {
            return _packID;
        }

        public LevelStruct GetLevelData(LevelStruct _levelId)
        {
            return _levelId;
        }

        public void SetCurrentPackID(int _PackID)
        {
            _currentPack = _PackID;
        }


        public int GetCurrentPackID()
        {
            return _currentPack;
        }

        public void SetCurrentLevelID(int _PackID)
        {
            _currentLevel = _PackID;
        }


        public int GetCurrentLevelID()
        {
            return _currentLevel;
        }
    }
}