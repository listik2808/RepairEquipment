using UnityEngine;

namespace Scripts.Employer
{
    public interface IWork
    {
        void OfferJob();
        bool IsActiveWork { get; set; }
    }
}