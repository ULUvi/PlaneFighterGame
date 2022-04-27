using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletprefab;
    public bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (canShoot == true)
            { Shoot();
                canShoot = false;
                StartCoroutine(Timer());
            
            }
            
            
            
        }
        IEnumerator Timer()
        {
            yield return new WaitForSeconds(0.1f);
            canShoot = true;
        }

        void Shoot() {
           
            Instantiate(bulletprefab, FirePoint.position, FirePoint.rotation);
        }
    }
   
}
