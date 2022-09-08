using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ujikom.currency
{
    public class Currency : MonoBehaviour
    {
        [SerializeField] int _coin;

        public int coin => _coin;
        // Start is called before the first frame update


        public int GetCoin()
        {
            return coin;
        }

        public void addcoin(int _add)
        {

        }
        public bool spendcoin(int _spend)
        {
            return true;
        }
    }
}