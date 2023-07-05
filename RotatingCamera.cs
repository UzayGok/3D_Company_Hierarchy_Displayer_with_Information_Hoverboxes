using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCamera : MonoBehaviour
{
    public float test1;
    float lowestY;
    public bool updated = false;
    public GameObject hiddenRotator;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        //------------------------------------------------------------------------------------------------------------------------
        //Set the initial camera position accordingly with the size
        if (!updated)
        {
            transform.position = new Vector3(
                GetComponent<BootUp>().highestDistance * 0.9F,
                GetComponent<BootUp>().lowestY / 2F,
                GetComponent<BootUp>().highestDistance * 0.9F
            );
            transform.LookAt(new Vector3(0, GetComponent<BootUp>().lowestY / 2F, 0));

            hiddenRotator.transform.position = transform.position;
            hiddenRotator.transform.LookAt(new Vector3(0, GetComponent<BootUp>().lowestY / 2F, 0));
            updated = true;
        }

        lowestY = GetComponent<BootUp>().lowestY;
        if (Input.GetMouseButton(0))
        {
            //---------------------------------------------------------------------------------------------------------------------------
            //Horizontal movement

            hiddenRotator.transform.RotateAround(
                new Vector3(0, hiddenRotator.transform.position.y, 0),
                Vector3.up,
                Input.GetAxis("Mouse X") * 400F * Time.deltaTime
            );

            //---------------------------------------------------------------------------------------------------------------------------
            //Vertical movement
            if (Input.GetAxis("Mouse Y") < 0F)
            {
                if (
                    !(
                        hiddenRotator.transform.forward.y < 0F
                        && Vector3.Angle(hiddenRotator.transform.forward, new Vector3(0, 1, 0))
                            > 170F
                    )
                )
                {
                    hiddenRotator.transform.RotateAround(
                        new Vector3(0, GetComponent<BootUp>().lowestY / 2F, 0),
                        hiddenRotator.transform.right,
                        (-Input.GetAxis("Mouse Y")) * 200F * Time.deltaTime
                    );
                }
            }
            else if (Input.GetAxis("Mouse Y") > 0F)
            {
                if (
                    !(
                        hiddenRotator.transform.forward.y > 0F
                        && Vector3.Angle(hiddenRotator.transform.forward, new Vector3(0, 1, 0))
                            < 10F
                    )
                )
                {
                    hiddenRotator.transform.RotateAround(
                        new Vector3(0, GetComponent<BootUp>().lowestY / 2F, 0),
                        hiddenRotator.transform.right,
                        (-Input.GetAxis("Mouse Y")) * 200F * Time.deltaTime
                    );
                }
            }




        }

        hiddenRotator.transform.LookAt(new Vector3(0, GetComponent<BootUp>().lowestY / 2F, 0));
        transform.position =
            hiddenRotator.transform.position
            + new Vector3(
                0,
                ((hiddenRotator.transform.forward.y > 0F) ? -10 : +10)
                    * movementFunction(
                        Vector3.Angle(hiddenRotator.transform.forward, new Vector3(0, 1, 0))
                    ),
                0
            );
        transform.LookAt(new Vector3(0, GetComponent<BootUp>().lowestY / 2F, 0));
        test1 = movementFunction(
            Vector3.Angle(hiddenRotator.transform.forward, new Vector3(0, 1, 0))
        );
    }

    float movementFunction(float angle)
    {
        angle = Mathf.Abs(angle);
        if (angle > 90)
            angle = 180 - angle;

        angle = 90 - angle;
        angle /= 9F;
        return angle;


    }
}
