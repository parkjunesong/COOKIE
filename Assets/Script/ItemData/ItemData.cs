using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Scriptable Object/Item Data", order = 1000)]
public class ItemData : ScriptableObject
{
    //hp통, hp 감소율, hp 회복율, 점수 배율

    [SerializeField]
    private new string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    [SerializeField]
    private int hp;
    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }   

    [SerializeField]
    private float score;
    public float Score
    {
        get { return score; }
        set { score = value; }
    }

    [SerializeField]
    private Sprite image;
    public Sprite Image
    {
        get { return image; }
        set { image = value; }
    }
}
