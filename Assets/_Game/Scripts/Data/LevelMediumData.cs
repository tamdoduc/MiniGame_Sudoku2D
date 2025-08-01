using System.Collections.Generic;
using UnityEngine;
using Utils;

public class LevelMediumData : MonoBehaviour
{
    public static List<BoardData> GetData()
    {
        List<BoardData> data = new List<BoardData>();
        data.Add(new BoardData(
                new int[81] {
            0, 1, 4, 0, 0, 0, 3, 0, 3,
            0, 5, 1, 0, 8, 0, 0, 0, 0,
            0, 9, 0, 0, 6, 0, 1, 8, 0,
            6, 0, 0, 0, 3, 2, 5, 4, 0,
            0, 2, 6, 0, 7, 2, 0, 9, 0,
            0, 7, 0, 0, 0, 5, 8, 4, 0,
            2, 0, 4, 0, 8, 0, 7, 1, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0
                },
                new int[81] {
            2, 1, 4, 6, 7, 8, 9, 3, 5,
            3, 6, 9, 5, 1, 2, 8, 7, 4,
            5, 8, 7, 4, 3, 9, 1, 2, 6,
            4, 2, 1, 8, 9, 6, 3, 5, 7,
            7, 9, 3, 2, 5, 6, 4, 8, 1,
            8, 5, 6, 1, 4, 7, 2, 9, 3,
            9, 3, 2, 7, 6, 1, 5, 4, 8,
            1, 7, 5, 9, 8, 3, 6, 2, 4,
            6, 4, 8, 3, 2, 5, 7, 1, 9
                }
            ));
        return data;
    }
}
