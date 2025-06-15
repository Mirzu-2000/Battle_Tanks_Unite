using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;

        public float rotationSpeed;

        public TankTypes tankType;

        public Material color;


    }

    public List<Tank> tanklist;

   public TankView tankView;
    void Start()
    {
       
    }

    public void CreateTank(TankTypes tankType)
    {
        if (tankType == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tanklist[0].movementSpeed, tanklist[0].rotationSpeed, tanklist[0].tankType, tanklist[0].color);

            TankController tankController = new TankController(tankModel, tankView);
        }

       else if (tankType == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tanklist[1].movementSpeed, tanklist[1].rotationSpeed, tanklist[1].tankType, tanklist[1].color);

            TankController tankController = new TankController(tankModel, tankView);
        }

        else if (tankType == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tanklist[2].movementSpeed, tanklist[2].rotationSpeed, tanklist[2].tankType, tanklist[2].color);

            TankController tankController = new TankController(tankModel, tankView);
        }

    }

}
