using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
   public TankView tankView;
    void Start()
    {
        //Instantiate(tankView.gameObject, transform.position, Quaternion.identity);
        CrateTank();
    }

    private void CrateTank()
    { 
     TankModel tankModel = new TankModel(30,20);

     TankController tankController = new TankController(tankModel,tankView);

    }
   
}
