using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ujikom.Data;


namespace Ujikom.selectpack
{
    [System.Serializable]
    public class PackModel
    {
        public string PackID;
        public string Packname;
        public bool IsComplete;
        public bool IsUnlocked;
        public int UnlockCost;


    }
}