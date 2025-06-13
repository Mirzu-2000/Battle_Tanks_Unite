using UnityEngine;

public class TankModel 
{
    public float movenentSpeed;
    public float rotationSpeed;

    private TankController tankController;


    public TankModel(float _movementSpeed, float _rotationSpeed) 
    {
        movenentSpeed = _movementSpeed;
       rotationSpeed = _rotationSpeed;
    }

    public void SetTankController(TankController tankController)
    { 
      this.tankController  = tankController;
    }

}
