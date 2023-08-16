using Scripts.Hero;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Employer
{
    public abstract class Work :MonoBehaviour, IWork
    {
        [SerializeField] protected List<GameObject> _points = new List<GameObject>();

        protected bool _isActiveWork;

        public List<GameObject> Points => _points;

        public abstract void WorkActivate();

        public abstract void JobDescriptions(Player player);

        public abstract void Show();
    }
}