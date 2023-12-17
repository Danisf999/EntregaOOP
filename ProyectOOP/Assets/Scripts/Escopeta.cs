public class Escopeta : Arma //HERENCIA
{
    //POLIMORFISMO
    public override void ArmaPosition()
    {
        transform.position = new UnityEngine.Vector3(0.22f, 2.7f, 1.21f);
    }
}
