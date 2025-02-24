using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    public float hiz = 5f; // Hareket h�z�

    void Update()
    {
        float yatay = Input.GetAxis("Horizontal"); // sol-Sa� ok tu�lar�
        float dikey = Input.GetAxis("Vertical");   // Yukar�-A�a�� ok tu�lar�

        Vector3 hareket = new Vector3(yatay, 0, dikey) * hiz * Time.deltaTime;
        transform.Translate(hareket);
    }
}
