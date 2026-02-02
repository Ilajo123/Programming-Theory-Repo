using UnityEngine;

public class BigFruits: Fruits
{
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        damage = 1.5f;
        fallSpeed = 15f;
        points = 4f;
    }



    public override void OnCaught()
    {
        onCatch?.Invoke(points);
        Destroy(gameObject);
    }

    public override void DestroyFruit()
    {
        onOutOfBounds.Invoke(damage);
        Destroy(gameObject);
    }
}
