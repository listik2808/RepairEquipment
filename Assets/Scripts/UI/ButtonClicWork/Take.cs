using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.UI.BottonClicWork
{
    public class Take : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public event Action TookTask;

        private void OnEnable()
        {
            _button.onClick.AddListener(AcceptTask);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(AcceptTask);
        }

        private void AcceptTask()
        {
            TookTask?.Invoke();
        }
    }
}