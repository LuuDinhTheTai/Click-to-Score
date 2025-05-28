using UnityEngine;

public class WhiteSquare : MonoBehaviour
{
    void Start()
    {
        Camera.main.backgroundColor = Color.black;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {  
            Destroy(gameObject);
            Spawn();
        }
    }

    private void Spawn()
    {
        // Tạo vị trí ngẫu nhiên trong khung nhìn camera
        Vector2 randomViewPos = new Vector2(Random.value, Random.value);
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(new Vector3(randomViewPos.x, randomViewPos.y, 10f));

        // Tạo GameObject mới (ô trắng)
        GameObject newSquare = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newSquare.transform.position = worldPos;
        newSquare.transform.localScale = new Vector3(1, 1, 1);

        // Đặt màu trắng cho ô vuông
        var renderer = newSquare.GetComponent<Renderer>();
        renderer.material.color = Color.white;

        // Gắn lại script để có thể click tiếp
        newSquare.AddComponent<WhiteSquare>();
    }
}