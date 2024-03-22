using System.Collections.Generic;
using UnityEngine;
public class ColorChanger : MonoBehaviour
{
    public List<Color> colors;
    private int currentColorIndex = 0; 
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 mousePosition =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit.collider != null && hit.transform == this.transform) 
            {
                currentColorIndex = (currentColorIndex + 1) % colors.Count;
                GetComponent<SpriteRenderer>().color = colors[currentColorIndex];
            }
        }
    }
}



// using System.Collections.Generic;
// using UnityEngine;

// public class ColorChanger : MonoBehaviour
// {
//     public List<Color> colors;
//     private int index = 0;

//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0) && Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero).collider != null)
//             GetComponent<SpriteRenderer>().color = colors[index = (index + 1) % colors.Count];
//     }
// }
