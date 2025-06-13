using UnityEngine;

public class TankModel 
{
    public float movenentSpeed;

    public float rotationSpeed;

    public Material color;

    public TankTypes tankTypes;


    private TankController tankController;


    public TankModel(float _movementSpeed, float _rotationSpeed, TankTypes _tankTypes, Material _color) 
    {
        movenentSpeed = _movementSpeed;
        rotationSpeed = _rotationSpeed;
        tankTypes = _tankTypes;
        color = _color;
    }

    public void SetTankController(TankController tankController)
    { 
      this.tankController  = tankController;
    }

}
