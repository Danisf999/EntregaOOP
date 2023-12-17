public class Fusil : Arma //HERENCIA
{
    //POLIMORFISMO
    public override void ArmaPosition()
    {
        transform.position = new UnityEngine.Vector3(0.22f, 2.67f, 0.95f);
    }
}
