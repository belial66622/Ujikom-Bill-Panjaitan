
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ujikom.Data;

namespace Ujikom.scriptableobject { 
[System.Serializable]
public struct Pack 
{
        public string PackID;
        public string Packname;
        public bool IsComplete;
        public bool IsUnlocked;
        public int UnlockCost;
       public LevelStruct[] level;
}
}