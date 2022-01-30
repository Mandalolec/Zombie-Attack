using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool dead = false;
    private float speedRotate = 1000f;
    public float waitBtwShoot = 0.1f;
    public GameObject bullet;
    public GameObject lose;
    public Transform shootPoint;
    public Transform targetLook;


    void Start()
    {
        StartCoroutine(shooting());
    }
    IEnumerator shooting()
    {
        if (!dead)
        {
            while(!dead)
            {
                GameObject bulletTf = Instantiate(bullet, shootPoint.position, Quaternion.identity); 
                bulletTf.GetComponent<BulletMove>().Setup(transform.forward);
                yield return new WaitForSeconds(waitBtwShoot);
            }
        }
    }
    void Update()
    {
        TargetLook();
    }

    private void TargetLook()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray touchPosition = Camera.main.ScreenPointToRay(touch.position);
            if (Physics.Raycast(touchPosition, out RaycastHit raycastHit))
            {
                Vector3 distance = raycastHit.point - transform.position;
                distance.y = 0;
                Quaternion targetRotation = Quaternion.LookRotation(distance);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * speedRotate);

                targetLook.position = Vector3.Lerp(targetLook.position, raycastHit.point, Time.deltaTime * 40);
            }
        }
    }

    private void OnTriggerStay(Collider other) 
    {
        if (other.CompareTag("Enemy"))
        {
            dead = true;
            lose.SetActive(true);
            PlayerPrefs.SetInt("Score", ScoreCount.enemys);
        }
    }
}
