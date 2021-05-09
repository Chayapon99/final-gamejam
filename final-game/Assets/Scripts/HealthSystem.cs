using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;


    public void TakeDamage()
    {
        if (life >= 1)
        {
            life -= 1;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                
            }
        }
    }
}
