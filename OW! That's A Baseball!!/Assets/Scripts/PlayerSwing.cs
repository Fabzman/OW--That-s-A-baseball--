using UnityEngine;

public class PlayerSwing : MonoBehaviour
{

    public float rotationSpeed = 10F;
    private float rotation;
    private float startRotation;
    public float neutralTimer;
    public bool neutralStance;

    bool hasReleased = false;

    private float angle;

    // Use this for initialization
    void Start()
    {
        rotation = transform.eulerAngles.y;
        startRotation = transform.eulerAngles.y;
        angle = startRotation;
        neutralTimer = 2f;
        neutralStance = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotation = 198F;
            hasReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rotation = -110F;
            neutralTimer = 2f;
            hasReleased = true;
        }

        if (neutralTimer > 0 && hasReleased)
        {
            neutralTimer -= Time.deltaTime;

            if (neutralTimer <= 0)
            {
                hasReleased = false;
                rotation = 45f;
            }
        }

        angle = Mathf.Lerp(angle, rotation, rotationSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle, transform.eulerAngles.z);
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(rotation, Vector3.up), rotationSpeed * Time.deltaTime);
    }

}
