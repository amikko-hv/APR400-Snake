using System.ComponentModel;

namespace APR400_Snake;

public class Snake
{
    // TODO: Appropriate data structure for the snakes body.
    // And implement algorithms in appropriate methods.
    // You may change and add methods as you see fit.
    
    /// <summary>
    /// Grow the snake by one segment.
    /// </summary>
    public void Grow()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Move the snake one step in the given direction.
    /// <param name="direction">Direction to move</param>
    /// </summary>
    public void Move(Direction direction)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Check if the Snakes' head collides with the snakes body. 
    /// </summary>
    /// <returns>True if collision is occuring</returns>
    public bool IsBodyCollision()
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Check if the Snakes' head collides with a wall on the game board. 
    /// </summary>
    /// <param name="gameBoard">The game board</param>
    /// <returns>True if collision is occuring</returns>
    public bool IsWallCollision(GameBoard gameBoard)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Check if the Snakes' head collides the food
    /// </summary>
    /// <returns>True if collision is occuring</returns>
    public bool IsFoodCollision(/* TODO: GameBoard or Food object argument */)
    {
        throw new NotImplementedException();
    }
}
