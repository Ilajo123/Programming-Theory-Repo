using UnityEngine;


public class SmallFruits : Fruits  //INHERITANCE
{
   
    private void Start() 
    {
        rb = GetComponent<Rigidbody>();
        damage = 1f;
        fallSpeed = 10f;
        points = 2f;
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
