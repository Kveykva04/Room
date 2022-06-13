using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Room;
namespace Room
{
    public class TimeScript : MonoBehaviour
    {
        public Text screenText;
        public GameObject theDisplay;
        public int hour;
        public int minutes;
        public int seconds;

        private string getHour()
        {
            hour = System.DateTime.Now.Hour;
            return hour.ToString();
        }

        private string getMinute()
        {
            minutes = System.DateTime.Now.Minute;
            return minutes.ToString();
        }

        private string getSecond()
        {
            seconds = System.DateTime.Now.Second;
            return seconds.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            screenText.text = getHour() + ":" + getMinute() + ":" + getSecond();
        }
    }
}
