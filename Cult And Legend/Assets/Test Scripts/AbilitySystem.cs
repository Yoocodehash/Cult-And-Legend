using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitySystem : MonoBehaviour
{

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */


    public ShootingAbility shootingAbility;
    public float jumpHeight = 5f;
    public float jumpCooldown = 1f;

    private float jumpCooldownTimer;


}
