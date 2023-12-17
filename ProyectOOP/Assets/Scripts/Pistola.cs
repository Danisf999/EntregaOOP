public class Pistola : Arma //HERENCIA
{
    //POLIMORFISMO
    public override void ArmaPosition()
    {
        transform.position = new UnityEngine.Vector3(0.17f, 2.67f, 0.85f);
    }
}
