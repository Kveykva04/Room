using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Room;
namespace Room
{
    public class RandomWord : MonoBehaviour
    {
        string[] list = {"Ping Pong", "Fly", "Bear", "Piano", "Chop", "Tree", "Snowball", "Penguin", "Nap", "Beg", "Rhinoceros", "Fetch", "Jog", "Cow", "Swimming", "Reading", "Cooking", "Cleaning", "Driving a Car", "Cleaning", "Boxing", "Opening a Door", "Shark", "Kangaroo", "Chicken", "Spider", "Monkey", "Bird", "Dog"};
        public Text screenText;
        public GameObject theDisplay;

        string getRandomWord()
        {
            int random = (int)(Random.Range(0, list.Length));
            return list[random];
        }
        // Update is called once per frame
        void Update()
        {
            screenText.text = getRandomWord();
        }
    }
}