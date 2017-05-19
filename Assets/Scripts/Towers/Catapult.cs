using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : Turret
{

    
    protected override void Start()
    {
        //Use the base Start 
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
    protected override void FindTarget()
    {
        base.FindTarget();
    }
    protected override void Shoot()
    {
        // Set our reference object and our firing location
        GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //Attach the Bullet script to the clones
        Bullet bullet = bulletGO.GetComponent<Bullet>();
        // If we have an active bullet
        if (bullet != null)
        {
            // make it seek the current target
            bullet.Seek(target);
        }
    }
    protected override void OnDrawGizmosSelected()
    {
        base.OnDrawGizmosSelected();
    }

}
