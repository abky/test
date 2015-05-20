using System.Collections.Generic;

namespace MySolution.ChessUtils
{
    public class MoveCalculator
    {
        private static readonly int[] KnightOffsetsX = {1, 2, 2, 1, -1, -2, -2, -1};
        private static readonly int[] KnightOffsetsY = {2, 1, -1, -2, -2, -1, 1, 2};

        public ChessPosition[] GetKnightMoves(ChessPosition currentPosition)
        {
            if (currentPosition.Equals(ChessPosition.Empty))
            {
                return new ChessPosition[0];
            }

            var result = new List<ChessPosition>();

            for (var i = 0; i < KnightOffsetsX.Length; i++)
            {
                var newPositionX = currentPosition.X + KnightOffsetsX[i];
                var newPositionY = currentPosition.Y + KnightOffsetsY[i];

                if (newPositionX >= ChessPosition.MinValue && newPositionX <= ChessPosition.MaxValue &&
                    newPositionY >= ChessPosition.MinValue && newPositionY <= ChessPosition.MaxValue)
                {
                    result.Add(new ChessPosition(newPositionX, newPositionY));
                }
            }

            return result.ToArray();
        }
    }
}
