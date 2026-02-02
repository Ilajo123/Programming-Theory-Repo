using UnityEngine;

public class BigFruits: Fruits  //INHERITANCE
{
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        damage = 1.5f;
        fallSpeed = 15f;
        points = 4f;
    }



    public override void OnCaught() //POLYMORPHISM
    {
        onCatch?.Invoke(points);
        Destroy(gameObject);
    }

    public override void DestroyFruit()  //POLYMORPHISM
    {
        onOutOfBounds.Invoke(damage);
        Destroy(gameObject);
    }
}
