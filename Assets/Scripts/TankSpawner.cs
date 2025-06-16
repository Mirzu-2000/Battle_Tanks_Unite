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
        //Instantiate(tankView.gameObject, transform.position, Quaternion.identity);
        CrateTank();
    }

    private void CrateTank()
    { 
     TankModel tankModel = new TankModel(tanklist[01].movementSpeed,tanklist[01].rotationSpeed,tanklist[01].tankType,tanklist[01].color);

     TankController tankController = new TankController(tankModel,tankView);

    }
   
}
