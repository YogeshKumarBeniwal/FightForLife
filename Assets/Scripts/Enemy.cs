using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float atackSpeed = 3f;
    private GameObject player;
    private Transform enemyTransform;
    private Rigidbody enemyRB;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemyTransform = transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 lookDirection = (player.transform.position - enemyTransform.position).normalized;

        gameObject.GetComponent<Rigidbody>().AddForce(lookDirection * atackSpeed);
    }
}
