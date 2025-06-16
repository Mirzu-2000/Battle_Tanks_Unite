using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// TankSpawner is responsible for spawning tanks based on TankType.
/// </summary>
public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        [Header("Tank Configurations")]
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    #region Public References

    [Header("Tank Setup")]
    public List<Tank> tanklist;

    [Header("Prefab Reference")]
    public TankView tankView;

    #endregion

    #region Public Methods

    public void CreateTank(TankTypes tankType)
    {
        Tank selectedTank = tanklist.Find(tank => tank.tankType == tankType);

        if (selectedTank != null)
        {
            TankModel tankModel = new TankModel(
                selectedTank.movementSpeed,
                selectedTank.rotationSpeed,
                selectedTank.tankType,
                selectedTank.color
            );

            TankController tankController = new TankController(tankModel, tankView);
        }
        else
        {
            Debug.LogWarning($"No configuration found for tank type: {tankType}");
        }
    }

    #endregion
}
