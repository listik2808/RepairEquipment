using Scripts.Hero;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Employer
{
    public class GoWork : MonoBehaviour
    {
        [SerializeField] private List<Transform> _point;

        private IWork work;

        private void Start()
        {
            work = new PickUpMail();
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent( out HeroMove heroMove ) )
            {
                work.OfferJob();
            }
        }
    }
}