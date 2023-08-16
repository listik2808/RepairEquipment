using Scripts.Hero;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Employer
{
    public interface IWork
    {
        void WorkActivate();
        void Show();
        void JobDescriptions(Player player);
    }
}