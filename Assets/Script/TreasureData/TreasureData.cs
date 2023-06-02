using UnityEngine;

[CreateAssetMenu(fileName = "TreasureData", menuName = "Scriptable Object/Treasure Data", order = 100)]
public class TreasureData : ScriptableObject
{
    //hp��, hp ������, hp ȸ����, ���� ����

    [SerializeField]
    private new string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    [SerializeField]
    private string ability;
    public string Ability
    {
        get { return ability; }
        set { ability = value; }
    }

    [SerializeField]
    private string text;
    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    [SerializeField]
    private int hp;
    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }

    [SerializeField]
    private float hp_plus;
    public float HP_P
    {
        get { return hp_plus; }
        set { hp_plus = value; }
    }

    [SerializeField]
    private float hp_minus;
    public float HP_M
    {
        get { return hp_minus; }
        set { hp_minus = value; }
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
