using UnityEngine;

/// <summary>
/// TankController acts as the mediator between TankModel and TankView.
/// It handles user input logic and applies it to the Rigidbody.
/// </summary>
public class TankController
{
    #region Private Fields

    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;

    #endregion

    #region Constructor

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;

        // Instantiate the View
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();

        // Set references
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        // Apply tank color
        tankView.ChangeColor(tankModel.color);
    }

    #endregion

    #region Public Movement Methods

    /// <summary>
    /// Moves the tank forward or backward.
    /// </summary>
    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    /// <summary>
    /// Rotates the tank based on input.
    /// </summary>
    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 rotationVector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(rotationVector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    /// <summary>
    /// Gets the associated TankModel.
    /// </summary>
    public TankModel GetTankModel()
    {
        return tankModel;
    }

    #endregion
}
