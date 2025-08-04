using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{

}

public enum GameMode
{
    RoleMode,//身份模式
    CountryMode,//国战模式
    DouDiZhuMode,//斗地主模式
    OneOnOneMode,//单挑模式
    TwoOnTwoMode,//欢乐2V2模式
    VersusMode,//4V4对战模式
}

public enum Identity
{
    Monarch,//主公
    Loyalist,//忠臣
    Rebel,//反贼
    Renegade,//内奸
}

public enum Factions
{
    Wei,//魏国
    Shu,//蜀国
    Wu,//吴国
    Qu,//群雄
    Jin,//晋国
    God,//神
    Monster,//怪物
    none,//无
}

public enum DamageType
{
    Normal,//普通伤害
    Fire,//火焰伤害
    Thunder,//雷电伤害
    Ice,//冰冻伤害
}

public enum SkillType
{
    Compulsory,//锁定技
    Initiative,//主动技
    Invisible,//隐匿技
    Awakening,//觉醒技
    Limited,//限定技
    Lord,//主公技
}

public enum Gender
{
    Male,//男性
    Female,//女性
    Neutral,//中性/无性别
}

public enum PlayerArea
{
    Hand,//手牌区
    Equip,//装备区
    Judge,//判定区
    OnTop,//武将牌上
}

public enum RoundStage
{
    RoundStart,//回合开始
    ReadyStart,//准备阶段开始
    Ready,//准备阶段
    ReadyEnd,//准备阶段结束
    JudgmentStart,//判定阶段开始
    Judgment,//判定阶段
    JudgmentEnd,//判定阶段结束
    DrawStart,//摸牌阶段开始
    Draw,//摸牌阶段
    DrawEnd,//摸牌阶段结束
    PlayStart,//出牌阶段开始
    Play,//出牌阶段
    PlayEnd,//出牌阶段结束
    DiscardStart,//弃牌阶段开始
    Discard,//弃牌阶段
    DiscardEnd,//弃牌阶段结束
    EndStart,//结束阶段开始
    End,//结束阶段
    EndEnd,//结束阶段结束
    RoundEnd,//回合结束
}

public enum CardType
{
    Basic,//基本牌
    Equip,//装备牌
    Trick,//锦囊牌
}

public enum Suit
{
    Spade,//黑桃
    Heart,//红桃
    Club,//梅花
    Diamond,//方片
    None,//无花色
}

public enum CardColor
{
    Red,//红色(红桃、方片)
    Black,//黑色(黑桃、梅花)
    None,//无色
}

public enum EquipType
{
    Weapon,//武器
    Armor,//防具
    DefensiveHorse,//防御马(-1马)
    OffensiveHorse,//攻击马(+1马)
    Treasure,//宝物
}

public enum PlayerState
{
    Normal,//正常状态
    Horizontally,//横置
    BackUp,//翻面
    Dying,//濒死
    Dead,//死亡
    Reborn,//重整
    Invisible,//隐匿
}