using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUpTrap : MonoBehaviour
{
    public float moveSpeed = 5f;    // Speed of the movement

    void Start()
    {
        StartCoroutine(MoveUpDown());
    }

    IEnumerator MoveUpDown()
    {
        while (true)
        {
            // Move up
            while (transform.position.y < -0.4)
            {
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                yield return null;
            }

            // Wait for 2 seconds
            yield return new WaitForSeconds(2f);

            // Move down
            while (transform.position.y > -3.2)
            {
                transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                yield return null;
            }

            // Wait for 2 seconds
            yield return new WaitForSeconds(2f);
        }
    }
}
