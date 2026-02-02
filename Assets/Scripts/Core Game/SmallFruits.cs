using UnityEngine;

public class SmallFruits : Fruits
{
   
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        damage = 1f;
        fallSpeed = 10f;
        points = 2f;
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
