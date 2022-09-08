using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ujikom.SaveData
{
    [System.Serializable]
    public class SaveData
    {
        public int coin;
        public string[] UnlockedPack;
        public string[] CompletedPack;
        public string[] CompletedLevel;
    }
}