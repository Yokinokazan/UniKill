using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card
{
    public string Name { get { return _name; } }

    public string Description { get { return _description; } }

    public Card[] Entities { get { return _entities; } }

    public CardType Type { get { return _type; } }

    public Suit Suit { get { return _suit; } }

    public int Points { get { return _points; } }

    public CardColor color
    {
        get
        {
            //如果没有实体卡，返回无色
            if (_entities == null || _entities.Length == 0)
            {
                return CardColor.None;
            }
            //如果只有一张实体卡，返回该卡的花色对应颜色
            if (_entities.Length == 1)
            {
                //红桃或方片为红色
                if (_entities[0].Suit == Suit.Heart || _entities[0].Suit == Suit.Diamond)
                {
                    return CardColor.Red;
                }
                //黑桃或梅花为黑色
                if (_entities[0].Suit == Suit.Spade || _entities[0].Suit == Suit.Club)
                {
                    return CardColor.Black;
                }
                //如果没有匹配的花色，返回无色
                return CardColor.None;
            }
            //如果有多张实体卡，检查所有实体卡的花色
            //只有都为红色或都为黑色时，才返回对应颜色，其他情况都是无色
            bool allRed = true;
            bool allBlack = true;
            foreach (var entity in _entities)
            {
                if (entity.Suit == Suit.Heart || entity.Suit == Suit.Diamond)
                {
                    allBlack = false; //如果有红色，不能全是黑色
                }
                else if (entity.Suit == Suit.Spade || entity.Suit == Suit.Club)
                {
                    allRed = false; //如果有黑色，不能全是红色
                }
                else
                {
                    allRed = false; //如果有无花色，不能全是红色
                    allBlack = false; //如果有无花色，不能全是黑色
                }
            }
            if (allRed)
            {
                return CardColor.Red; //全部为红色
            }
            if (allBlack)
            {
                return CardColor.Black; //全部为黑色
            }
            return CardColor.None; //否则返回无色
        }
    }

    public long Id { get; protected set; }

    public bool IsVirtual
    {
        get
        {
            //没有实体卡时，视为虚拟卡
            return _entities == null || _entities.Length == 0;
        }
    }

    public bool IsTranslated
    {
        get
        {
            //如果有实体卡且实体卡数量大于1，视为转换牌
            if( _entities != null && _entities.Length > 1)
            {
                return true;
            }
            //如果有实体卡且实体卡数量为1，并且实体卡不是当前牌，视为转换牌
            if( _entities != null && _entities.Length == 1)
            {
                return _entities[0].Id != this.Id;
            }
            //否则视为非转换牌
            return false;
        }
    }


    public Card Clone()
    {
        //克隆的卡固定为虚拟卡，没有实体卡，ID也需要重新设置
        Card clone = (Card)this.MemberwiseClone();
        clone.Id = System.Guid.NewGuid().GetHashCode(); //使用新的GUID作为ID
        clone._entities = null; //克隆时不复制实体卡
        return clone;
    }


    private string _name;

    private Card[] _entities;

    private CardType _type;

    private Suit _suit;

    private int _points;

    private string _description;
}
