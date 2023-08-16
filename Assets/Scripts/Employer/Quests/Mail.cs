using Scripts.Hero;
using Scripts.TriggerZone;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.Employer.Quests
{
    public class Mail : MonoBehaviour,IMission
    {
        [SerializeField] private Image _image;
        [SerializeField] private Trigger _trigger;

        private Coroutine _imageTimeCorutine;

        private void OnEnable()
        {
            _trigger.InTrigger += CompletedMission;
        }

        private void OnDisable()
        {
            _trigger.InTrigger -= CompletedMission;
        }

        private void CompletedMission(Player player)
        {
            if(_imageTimeCorutine != null)
            {
                StopCoroutine(_imageTimeCorutine);
                _imageTimeCorutine = null;
            }
            _imageTimeCorutine = StartCoroutine(StartMission(player));
            //должно быть срабатывания ефекта при выполнении!! можно музыкальное сопровождения сделать !
        }

        private IEnumerator StartMission(Player player)
        {
            while (_image.fillAmount != 0 && player.ActiveTrigger)
            {
                _image.fillAmount -= 0.0004f; 
                yield return null;
            }
            if(player.ActiveTrigger && _image.fillAmount ==0)
            {
                player.AddCompletedTask();
                gameObject.SetActive(false);
                player.Settrigger(false);
            }
            
            _image.fillAmount = 1;
            Debug.Log("Запустить карутину по уменьшению картинки и с временем для выполнения задания !");
        }
    }
}