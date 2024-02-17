using UnityEngine;
using UnityEngine.UI;

public class DifBack : MonoBehaviour
{
    private Button button;
    float minSize;
    float size;
    float speed;
    bool big;
    float sin;
    float sin2;
    public GameObject Exa;
    bool back;
    public float speedchange;
    public float sizechange;
    public GameObject Bg;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        minSize = 0;
        size = 1;
        back=false;
        speed=0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (back == true)
        {
            if (size > minSize)
            {
                Exa.gameObject.transform.localScale = new Vector3(size, size, 0);
                size -= speed;
            }
            else
            {
                size = 1;
                back=false;
                Bg.SetActive(false);
                Exa.gameObject.SetActive(false);
            }
        }

        sin = Mathf.Sin(Time.time * speedchange * 8);
        sin2 = Mathf.Sin(Time.time * speedchange);
        if (big == true)
        {
            this.gameObject.transform.localScale = new Vector3(1.2f + sin * sizechange, 1.2f + sin * sizechange, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1 + sin2 * sizechange / 4, 1 + sin2 * sizechange / 4, 1);
        }
    }

    void Click()
    {
        
        back =true;
    }

    public void UP()
    {
        big = true;
    }
    public void Down()
    {
        big = false;
    }
}
