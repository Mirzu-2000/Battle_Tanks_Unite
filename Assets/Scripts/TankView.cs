using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;

    private float roatate;

    public Rigidbody rb;

    public MeshRenderer[] childs;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");

        cam.transform.SetParent(transform);
        cam.transform.position =  new Vector3(0f, 3f, -4f);
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().movenentSpeed);
        }

        if (roatate != 0)
        {
            tankController.Rotate(roatate, tankController.GetTankModel().rotationSpeed);
        }
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        Debug.Log(movement);
        roatate = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        for (int i = 0; i < childs.Length; i++)
        {
            childs[i].material = color;
        }
    }

}
