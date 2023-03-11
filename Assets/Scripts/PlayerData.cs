using System;

[Serializable]
public class PlayerData
{
    public string Name;
    public int Level;
    public int Gold;
}

[Serializable]
public class ListPlayer
{
    public PlayerData[] playerDatas;
}
