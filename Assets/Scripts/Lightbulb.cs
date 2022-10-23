using UnityEngine;
/// <summary>
/// this class has 'TogglePower()' method that make Light to enable or disable
/// Light of bulb Gameobject.
/// It has also method called 'SetLightColor(Color newColor)'.
/// then it sets 'bulbLight.color = newColor;'
/// It has also method called 'SetRandomColor()'.
/// It creates random color then sets it to bulbLight color.
/// </summary>

public class Lightbulb : MonoBehaviour
{
    public Light bulbLight;
    static bool isPowerOn = false;
    private void Start()
    {
        bulbLight.enabled = false;
    }
    public void TogglePower()
    {
        if (!isPowerOn)
        {
            bulbLight.enabled = true;
            isPowerOn = true;
        }
        else
        {
            bulbLight.enabled = false;
            isPowerOn = false;
        }
    }
    /// <summary>
    /// bulbLight.color = newColor;
    /// </summary>
    public void SetLightColor(Color newColor)
    {
        bulbLight.color = newColor;
    }
    public void SetRandomColor()
    {
        //Declaration
        //public static Color ColorHSV(float hueMin, float hueMax,
        //float saturationMin, float saturationMax,
        //float valueMin, float valueMax,
        //float alphaMin, float alphaMax);
        /*Returns Color A random color with HSV and alpha values 
         * in the (inclusive) input ranges. Values for each 
         * component are derived via linear interpolation of value.*/
        Color randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        bulbLight.color = randomColor;
    }
}
