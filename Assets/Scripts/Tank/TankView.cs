using UnityEngine;

/// <summary>
/// TankView handles the visual and input part of the tank.
/// </summary>
public class TankView : MonoBehaviour
{
    #region Private Fields

    private TankController tankController;
    private float movement;
    private float rotate;

    #endregion

    #region Public References

    [Header("Tank Components")]
    public Rigidbody rb;

    [Tooltip("Assign all mesh parts to apply material")]
    public MeshRenderer[] childs;

    #endregion

    #region Unity Callbacks

    void Start()
    {
        // Attach main camera to the tank
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.localPosition = new Vector3(0f, 3f, -4f);
    }

    void Update()
    {
        HandleInput();

        if (movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().movenentSpeed);
        }

        if (rotate != 0)
        {
            tankController.Rotate(rotate, tankController.GetTankModel().rotationSpeed);
        }
    }

    #endregion

    #region Public Methods

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        foreach (MeshRenderer part in childs)
        {
            part.material = color;
        }
    }

    #endregion

    #region Private Methods

    private void HandleInput()
    {
        movement = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
    }

    #endregion
}
