using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    public float hiz = 5f; // Hareket hýzý

    void Update()
    {
        float yatay = Input.GetAxis("Horizontal"); // sol-Sað ok tuþlarý
        float dikey = Input.GetAxis("Vertical");   // Yukarý-Aþaðý ok tuþlarý

        Vector3 hareket = new Vector3(yatay, 0, dikey) * hiz * Time.deltaTime;
        transform.Translate(hareket);
    }
}
