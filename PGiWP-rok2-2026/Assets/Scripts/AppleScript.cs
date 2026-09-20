using System.Collections;
using UnityEngine;

public class AppleScript : MonoBehaviour
{ 
    AudioSource m_AudioSource;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            m_AudioSource.Play();
            StartCoroutine(Delay());
        }
    }

 
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}