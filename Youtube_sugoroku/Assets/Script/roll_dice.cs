using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roll_dice : MonoBehaviour
{
    public Text dice_result;
    public int dice_value = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void roll()
    {
        dice_value = Random.Range(1, 7);
        dice_result.text = dice_value.ToString();
    }
}
