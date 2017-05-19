using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float bulletSpeed = 70;

    public void Seek(Transform _target)
    {
        // Set our target when we reference this script elsewhere
        target = _target;
    }

    public void Update()
    {
        // If we have no Target, destroy the bullet
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        // Else set the direction the bullet must travel
            Vector3 dir = target.position - transform.position;
        // And move ittowards it's target
        float distanceThisFrame = bulletSpeed * Time.deltaTime;
        //Once it hits the target
        if (dir.magnitude <= distanceThisFrame)
        {
            // Call the Hit Target Function
            HitTarget();
            return;
        }
        // Normalise the movement and direction of the bullet as it travels
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        Destroy(gameObject, 0.1f);
        //Debug.Log("We Hit the Target");
    }
}
