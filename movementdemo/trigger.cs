
using UnityEngine;

public class trigger : MonoBehaviour
{
        public GameObject Dialog;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Dialog.SetActive(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Dialog.SetActive(false);
        }
    }
    
}
