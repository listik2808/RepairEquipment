using TMPro;
using UnityEngine;

namespace Scripts.UI
{
    public class UIMoney : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Wallet _wallet;

        private void OnEnable()
        {
            _wallet.MoneyChanged += Show;
        }

        private void OnDisable()
        {
            _wallet.MoneyChanged -= Show;
        }

        private void Show()
        {
            _text.text = _wallet.Money.ToString();
        }
    }
}