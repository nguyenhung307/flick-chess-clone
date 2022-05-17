using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChessType
{
    None = 0,
    Pawn = 1,
    Rook = 2,
    Knight = 3,
    Bishop = 4,
    Queen = 5,
    King = 6

}
public class ChessPiece : MonoBehaviour
{
    public int team;
    public ChessType type;
    
}
