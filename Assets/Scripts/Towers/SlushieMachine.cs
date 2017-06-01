using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlushieMachine : Turret
{
    public float slowSpeed = 10f;
    public GameObject SlowRadius;
    public Vector3 slowScale;

    public Vector3 maxRadius = new Vector3 (10,10,10);
    protected override void Start()
    {
        base.Start();
        slowScale = new Vector3(1, 1, 1);
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
        SlowRadius.transform.localScale = maxRadius;

    }

    protected override void OnDrawGizmosSelected()
    {
        base.OnDrawGizmosSelected();
    }
}


