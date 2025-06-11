using UnityEngine;

public class TankController 
{
 private TankModel tankModel;
 private TankView tankView;


 public TankController(TankModel tankModel, TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = tankView;

        GameObject.Instantiate(this.tankView.gameObject);

        tankModel.SetTankController(this);
        tankView.SetTankController(this);
    }

}
