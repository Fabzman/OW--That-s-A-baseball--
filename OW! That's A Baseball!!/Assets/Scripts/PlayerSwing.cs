using UnityEngine;
using UnityEngine.UI;

public class PlayerSwing : MonoBehaviour
{

    public float rotationSpeed = 10F;
    private float rotation;
    private float startRotation;
    public float neutralTimer;
    public bool neutralStance;
    public Image powerBar;
    private float powerTimer = 0f;
    public AudioClip ouch;
    private ParticleSystem stars;
    public Text scoreText;

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
        stars = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotation = 198F;
            hasReleased = false;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            powerTimer += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rotation = -110F;
            neutralTimer = 2f;
            hasReleased = true;
            powerTimer = 0f;
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

        powerBar.fillAmount = powerTimer / 2;

        angle = Mathf.Lerp(angle, rotation, rotationSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle, transform.eulerAngles.z);
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(rotation, Vector3.up), rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(ouch, Camera.main.transform.position);
            stars.Play();
        }
    }

}
