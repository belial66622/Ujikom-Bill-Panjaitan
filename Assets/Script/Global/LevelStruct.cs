using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ujikom.Data{
    [System.Serializable]
    public struct LevelStruct
    {
        public string LevelID;
        public string PackID;
        public string Question;
        public string Hint;
        public string[] choice;
        public int answer;

    }
}