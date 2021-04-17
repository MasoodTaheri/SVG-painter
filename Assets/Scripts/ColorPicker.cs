using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public static Color SelectedColor { get; private set; }

    [SerializeField]
    private Renderer selectedColorPreview;

    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "ColorPicker")
                {
                    Debug.Log("hit ColorPicker");
                    var picker = hit.collider.GetComponent<ColorPicker>();
                    if (picker != null)
                    {
                        Renderer rend = hit.transform.GetComponent<Renderer>();
                        MeshCollider meshCollider = hit.collider as MeshCollider;

                        if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
                            return;

                        Texture2D tex = rend.material.mainTexture as Texture2D;
                        Vector2 pixelUV = hit.textureCoord;
                        pixelUV.x *= tex.width;
                        pixelUV.y *= tex.height;
                        SelectedColor = tex.GetPixel((int)pixelUV.x, (int)pixelUV.y);
                        if (selectedColorPreview != null)
                            selectedColorPreview.material.color = SelectedColor;
                    }
                }
                else
                {
                    Debug.Log("hit other");
                    selectedColorPreview = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                }

            }

            RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
        Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0);
            if (hit2)
            {
                //Debug.Log("hit2   " + hit2.collider.gameObject.name);
                //hit2.collider.gameObject.GetComponent<SpriteRenderer>().material.color = Color.cyan;
                //SelectedObject = hit2.collider.gameObject;
                Debug.Log("hit other2");
                selectedColorPreview = hit2.collider.gameObject.GetComponent<SpriteRenderer>();
            }
        }
    }
}
