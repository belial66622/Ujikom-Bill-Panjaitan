using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ujikom.Data;

namespace Ujikom.scriptableobject
{
    [CreateAssetMenu]
    public class DataPack : ScriptableObject
    {
        [SerializeField] Pack[] pack;

        public Pack[] GetPack()
        {
            return pack;
        }

        /*public string GetLevelID(int indexlevel, int indexpack)
        {
            return pack[indexpack].level[indexlevel].LevelID;
        }
        */

        

    }
}