using Scripts.Hero;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.TriggerZone
{
    public class Trigger : MonoBehaviour
    {
        public Action <Player> InTrigger;

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out Player player))
            {
                Debug.Log("в тригере");
                player.Settrigger(true);
                InTrigger?.Invoke(player);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                player.Settrigger(false);
            }
        }
    }
}