
using UnityEngine;


public abstract class Fruits : MonoBehaviour
{
    public System.Action<float> onOutOfBounds;
    public System.Action<float> onCatch;
    protected float fallSpeed;
    protected Rigidbody rb;
    private float m_Damage;
    protected float points;
    public float damage
    {
        get { return m_Damage; }
        set
        {
            if (value < 0)
            {
                m_Damage = 1;
            }
            else
            {
                m_Damage = value;
            }

        }
    }
    private void Update()
    {
        Fall();
        if (transform.position.y <= -10f)
        {
            DestroyFruit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnCaught();
        }
    }
    public abstract void DestroyFruit();
    public void Fall()
    {
        rb.linearVelocity = Vector3.down * fallSpeed;
    }
    public abstract void OnCaught();

   

   
}
