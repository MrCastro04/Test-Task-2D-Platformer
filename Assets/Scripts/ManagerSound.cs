using UnityEngine;

public class ManagerSound : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private AudioSource _audioSource;

    private void Awake()
    {
        if (_audioSource == null)
        {
            _audioSource = GetComponent<AudioSource>();
        }

        if (_audioSource == null)
        {
            _audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void PlaySound()
    {
        if (_audioClip != null && _audioSource != null)
        {
            _audioSource.PlayOneShot(_audioClip);
        }
    }

    public void PlaySoundLoop()
    {
        if (_audioClip != null && _audioSource != null)
        {
            _audioSource.clip = _audioClip;
            _audioSource.loop = true;
            _audioSource.Play();
        }
    }

    public void StopSound()
    {
        if (_audioSource != null)
        {
            _audioSource.Stop();
        }
    }
}