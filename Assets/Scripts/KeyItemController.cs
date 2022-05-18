using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool Door = false;
        [SerializeField] private bool Key = false;

        [SerializeField] private Keys _keys = null;

        private KeyDoor doorObject;

        private void Start()
        {
            if (Door)
            {
                doorObject = GetComponent<KeyDoor>();
            }
        }
        public void Interactoid()
        {
            if(Door)
            {
                doorObject.PlayAnimation();
            }

            else if (Key)
            {
                _keys.hasKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}