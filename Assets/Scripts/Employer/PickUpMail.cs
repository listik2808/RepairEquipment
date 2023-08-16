using Scripts.Hero;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Scripts.Employer
{
    public class PickUpMail : Work
    {
        [SerializeField] private TMP_Text _text;

        public const string Task = "Принеси мне письма";
        public const string Count = "ШТ";
        Player _player;

        private void Start()
        {
            Show();
        }

        public override void Show()
        {
            _text.text = $"{Task} {Points.Count}{Count}";
        }

        public override void JobDescriptions(Player player)
        {
            _player = player;
        }

        public override void WorkActivate()
        {
            if(_isActiveWork == false)
            {
                _isActiveWork = true;
                _player.SetPoints(_points);
                OpenPoint();
            }
        }

        private void OpenPoint()
        {
            for (int i = 0; i < _points.Count; i++)
            {
                _points[i].gameObject.SetActive(true);
            }
        }
    }
}