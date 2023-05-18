using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Door: MonoBehaviour
    {

        public ButtonSys Btn;
        public string NextRoom;


        private void OnTriggerEnter2D(Collider2D other)
        {
            Btn.door = this;
            var canvas = Btn.transform.parent;
            canvas.SetParent(transform);
            canvas.localPosition = new Vector3(0,3,0);
            Btn.gameObject.SetActive(true);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            Btn.gameObject.SetActive(false);
            Btn.door = null;
        }

        public void Interaction()
        {
            Bootstrap.Instance.RM.ChangeRoom(NextRoom);
        }
    }
}