using UnityEngine;

namespace Scripts.Employer
{
    public abstract class Work : IWork
    {
        [SerializeField] protected Transform _target;

        public bool IsActiveWork { get => IsActiveWork; set => IsActiveWork = value; }

        public abstract void OfferJob();
    }
}