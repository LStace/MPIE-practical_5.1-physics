using UnityEngine;

public class bowling_ball : MonoBehaviour
{
    float power = 0.0f;
    float spin = 0.0f;
    
    public float power_change = 50.0f;
    public float spin_change = 50.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.W)){
            power += power_change;
            Debug.Log(string.Format("Power: {0}", power));
        }

        if (Input.GetKeyDown(KeyCode.S)){
            power -= power_change;
            if (power < 0){
                power = 0;
                Debug.Log(string.Format("Power: {0}", power));
            }
        }

        if (Input.GetKeyDown(KeyCode.Q)){
            spin += spin_change;
            Debug.Log(string.Format("Spin: {0}", spin));
        }

        if (Input.GetKeyDown(KeyCode.E)){
            spin -= spin_change;
            Debug.Log(string.Format("Spin: {0}", spin));
        }
    }

    void FixedUpdate(){
        Rigidbody rb = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.D)){
            rb.linearVelocity = Vector3.right * 2.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("propel");
            rb.AddForce(new Vector3(0.0f, 0.0f, -power));
            rb.AddTorque(new Vector3(0.0f, spin, 0.0f));
        }
        
    }
}
