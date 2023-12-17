using UnityEngine;

//ABSTRACCION
public abstract class Arma : MonoBehaviour
{
                     //ENCAPSULAMIENTO
    [SerializeField] private Transform _pfPosArma;
    [SerializeField] private GameObject _pfBala;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;

    public void Shoot()
    {
        Instantiate(_pfBala, _pfPosArma.position, Quaternion.identity);
    }

    public void AudioShoot()
    {
        _audioSource.PlayOneShot(_audioClip);
    }

    //ABSTRACCION
    public abstract void ArmaPosition();
}
