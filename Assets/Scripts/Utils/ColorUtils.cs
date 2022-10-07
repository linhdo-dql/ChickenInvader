using UnityEngine;


public class ColorUtils
{
    private static Color[] _colors = { Color.magenta, Color.black, Color.white, Color.green, Color.clear, Color.cyan,  };
    public static Color GetRandomColor()
    {
        return _colors[Random.Range(0, _colors.Length)];
    }
}