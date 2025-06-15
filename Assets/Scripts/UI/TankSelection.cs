using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{

    public TankSpawner tankSpawner;
   public void BlueTankSelected()
   {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);


        Debug.Log("BLUE");
   }


    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);

        Debug.Log("Green");
    }

    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);

        Debug.Log("Red");
    }
}
