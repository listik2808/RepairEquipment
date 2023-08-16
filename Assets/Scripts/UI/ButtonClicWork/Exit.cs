using System;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.UI.BottonClicWork
{
    public class Exit : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public Action Close;

        private void OnEnable()
        {
            _button.onClick.AddListener(AcceptExit);
        }

        private void OnDisable()
        {
            _button?.onClick.RemoveListener(AcceptExit);
        }

        private void AcceptExit()
        {
            Close?.Invoke();
        }
    }
}