using UnityEngine;

public abstract class Arma : MonoBehaviour
{
    [SerializeField] private GameObject pfArma;
    [SerializeField] private GameObject pfBala;
    [SerializeField] private AudioSource audioSource;

    public void Shoot()
    {
        Instantiate(pfBala, pfArma.transform.position, Quaternion.identity);
    }

    public void AudioShoot(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public abstract void ArmaPosition();
}
