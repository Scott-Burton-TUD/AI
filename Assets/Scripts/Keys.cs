using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class Keys : MonoBehaviour
    {

        private KeyItemController door;
        public bool hasKey = false;


        void Update()
        {
            if(hasKey == true)
            {
                if(door)
                {
                    gameObject.SetActive(false);
                }
            }
        }
    }
}