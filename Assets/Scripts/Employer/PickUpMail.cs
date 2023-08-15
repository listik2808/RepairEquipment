using UnityEngine;

namespace Scripts.Employer
{
    public class PickUpMail : Work
    {
        public override void OfferJob()
        {
            Debug.Log("Вызвали метод на работу");
            //Тут нужно открывать канвас;
            // Выбор принять или отказаться от задания;
            // При выборе задания даеться из списка случайная точка;
        }
    }
}