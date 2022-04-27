using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashOfBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Flash;
    bool canShoot;


    private void Start()
    {
        canShoot = true;
        Flash.SetActive(false);

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (canShoot == true)
            {
                Flash.SetActive(true);
                canShoot = false;
                StartCoroutine(Timer());
                
            }
            IEnumerator Timer()
            {
                yield return new WaitForSeconds(0.1f);
                canShoot = true;
                Flash.SetActive(false);
            }

        }
    }
}
