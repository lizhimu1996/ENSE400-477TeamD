
using UnityEngine;

public class enter : MonoBehaviour
{
    public GameObject entere;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                entere.SetActive(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            entere.SetActive(false);
        }
    }
}
