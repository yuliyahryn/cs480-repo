using UnityEngine;

public class PistolBehavior : MonoBehaviour
{
    public GameObject laserTemplate;
    public Transform spawnPoint;

    public void ShootLaser()
    {
        GameObject projectile = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);
        projectile.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 1000);
    }
}