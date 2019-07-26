using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLook : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Quaternion rot;
    public Vector3 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rot = Quaternion.LookRotation(transform.position - mousePosition,
                                                     Vector3.forward);
            GameObject bullet = Instantiate(bulletPrefab, transform.position, rot);
                bullet.GetComponent<Rigidbody2D>().velocity = transform.up * 5.0f;
                bullet.transform.LookAt(mousePosition);
                Destroy(bullet, 1);


                //Debug.Log("Test souris click droite");

            }

        
    }
}
