using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Hero
{
    public class Player : MonoBehaviour
    {
        private List<GameObject> _pointTarget = new List<GameObject>();
        private int _countMission;
        private int _completedTasks = 0;
        private bool _activeTrigger = false;

        public bool ActiveTrigger => _activeTrigger;

        public Action Selected;

        public void SetPoints(List<GameObject> transforms)
        {
            _pointTarget = transforms;
            _countMission = _pointTarget.Count;
        }

        public void AddCompletedTask()
        {
            _completedTasks++;
        }

        public void Settrigger(bool value)
        {
            _activeTrigger = value;
        }
    }
}