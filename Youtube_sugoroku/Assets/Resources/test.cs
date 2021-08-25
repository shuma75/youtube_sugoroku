using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]
/**
 * キャラクタサンプルクラス
 */
public class test : ScriptableObject
{
    //! 体力
    [SerializeField]
    int m_hp_now = 100;                          //!< 現在値
    [SerializeField]
    int m_hp_max = 100;                          //!< 最大値

    [SerializeField]
    float m_spd = 6.4f;                         //!< 移動速度

    [SerializeField]
    string m_name = "星宮";                     //!< キャラ名

    [SerializeField]
    List<GameObject> m_friends = new List<GameObject>();       //!< 友達リスト


    //! 拡張クラスからアクセスするために getter/setter を用意してね！ (他でも使うと思うけど)
    public int hp { get { return m_hp_now; } set { m_hp_now = value; } }
    public int maxHp { get { return m_hp_max; } set { m_hp_max = value; } }
    public float speed { get { return m_spd; } set { m_spd = value; } }
    public string charaName { get { return m_name; } set { m_name = value; } }
    public List<GameObject> friends { get { return m_friends; } set { m_friends = value; } }
}
