using UnityEngine;

/// <summary>
/// TankModel holds data related to the tank (speed, type, color, etc.).
/// </summary>
public class TankModel
{
    #region Public Properties

    public float movenentSpeed;
    public float rotationSpeed;
    public Material color;
    public TankTypes tankTypes;

    #endregion

    #region Private Fields

    private TankController tankController;

    #endregion

    #region Constructor

    public TankModel(float _movementSpeed, float _rotationSpeed, TankTypes _tankTypes, Material _color)
    {
        movenentSpeed = _movementSpeed;
        rotationSpeed = _rotationSpeed;
        tankTypes = _tankTypes;
        color = _color;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Assigns the controller to this model.
    /// </summary>
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }

    #endregion
}
