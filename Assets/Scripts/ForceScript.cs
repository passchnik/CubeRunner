using UnityEngine;
using UnityEngine.UI;

public class ForceScript : MonoBehaviour
{
    public float ForcePower;
    public float NumberOfPriority;


	private bool Switch=false;
    
    void Start()
	{
		Invoke("SwitchTurn", NumberOfPriority);  
	}

    void SwitchTurn()
	{
        
		Switch = true;
	}

    // Update is called once per frame
    void FixedUpdate()
    {
		if ((this.GetComponent<Transform>().position.y <= 0.75) && (Switch== true))
        {

			this.GetComponent<Rigidbody>().AddForce(0, ForcePower * Time.deltaTime, 0, ForceMode.VelocityChange);

		}
	}
}
