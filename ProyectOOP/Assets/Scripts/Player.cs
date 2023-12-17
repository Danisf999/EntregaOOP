using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Arma[] armas;
    //ENCAPSULACION
    public int currentIndexArmas { get; private set; }

    private void Start()
    {
        armas[currentIndexArmas].gameObject.SetActive(true);

        foreach (var arma in armas)
        {
            arma.ArmaPosition();
        }       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ChangeWeapon();
        }

        if (Input.GetMouseButtonDown(0))
        {
            ShootSetUp();
        }
    }

    public void ShootSetUp()
    {
        armas[currentIndexArmas].Shoot();
        armas[currentIndexArmas].AudioShoot();
    }

    public void ChangeWeapon()
    {
        armas[currentIndexArmas].gameObject.SetActive(false);
        currentIndexArmas = (currentIndexArmas + 1) % armas.Length;
        armas[currentIndexArmas].gameObject.SetActive(true);
    }
}