using UnityEngine;

[CreateAssetMenu(fileName = "CharaData", menuName = "Scriptable Object/Chara Data", order = 1)]
public class CharaData : ScriptableObject
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
    private Sprite standing;
    public Sprite Standing
    {
        get { return standing; }
        set { standing = value; }
    }

    [SerializeField]
    private RuntimeAnimatorController ani;
    public RuntimeAnimatorController Ani
    {
        get { return ani; }
        set { ani = value; }
    }
}
