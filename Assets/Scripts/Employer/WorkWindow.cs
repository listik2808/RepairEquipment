using Scripts.Hero;
using Scripts.UI.BottonClicWork;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Employer
{
    public class WorkWindow : MonoBehaviour
    {
        [SerializeField] private Canvas _canvas;
        [SerializeField] private Take _take;
        [SerializeField] private Exit _exit;

        private IWork _work;
        

        private void OnEnable()
        {
            _take.TookTask += GetTasks;
            _exit.Close += CloseCanvas;
        }

        private void OnDisable()
        {
            _take.TookTask -= GetTasks;
            _exit.Close -= CloseCanvas;
        }

        private void Awake()
        {
            _work = GetComponent<Work>();
        }

        private void Start()
        {
            CloseCanvas();
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent( out Player player ))
            {
                OpenCanvas();
                _work.JobDescriptions(player);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if(other.TryGetComponent(out HeroMove heroMove) )
            {
                CloseCanvas();
            }
        }

        private void GetTasks()
        {
             _work.WorkActivate();
            CloseCanvas();
            _take.gameObject.SetActive(false);
        }

        private void CloseCanvas()
        {
            _canvas.gameObject.SetActive(false);
        }

        private void OpenCanvas()
        {
            _canvas.gameObject.SetActive(true);
        }
    }
}