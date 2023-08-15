using System;
using UnityEngine;

namespace Scripts.UI
{
    public class Wallet : MonoBehaviour
    {
        private int _money =0;

        public Action MoneyChanged;
        public int Money
        {
            get => _money;
            set  
            { 
                if(_money != value)
                {
                    _money = value;
                    MoneyChanged?.Invoke();
                }
            }
        }
    }
}