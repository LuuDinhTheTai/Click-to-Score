using UnityEngine;

public class WhiteSquare : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("White square clicked");
        ScoreBoard.score += 1;
        Destroy(gameObject);
        Spawn();
    }

    private void Spawn()
    {
        // Camera thường ở z = -10 => Chọn z = 0 cho WorldPos là phổ biến
        Vector2 vp = new Vector2(Random.value, Random.value);
        float z = 0f; // Đặt đúng z trên mặt phẳng camera nhìn thấy
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(new Vector3(vp.x, vp.y, Mathf.Abs(Camera.main.transform.position.z) + z));

        GameObject sq = GameObject.CreatePrimitive(PrimitiveType.Cube);

        sq.transform.position = worldPos;
        sq.transform.localScale = Vector3.one;
        sq.GetComponent<Renderer>().material.color = Color.white;
        sq.AddComponent<WhiteSquare>();
    }

    private void Start()
    {
        Camera.main.backgroundColor = Color.black;
    }
}