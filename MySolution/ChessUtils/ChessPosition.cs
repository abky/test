using System;

namespace MySolution.ChessUtils
{
    public struct ChessPosition
    {
        public const int MinValue = 1;
        public const int MaxValue = 8;

        public ChessPosition(int x, int y)
        {
            if (!IsValid(x))
            {
                throw new ArgumentException(GetInvalidValueMessage("x"));
            }
            if (!IsValid(y))
            {
                throw new ArgumentException(GetInvalidValueMessage("y"));
            }

            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public static ChessPosition Empty
        {
            get { return new ChessPosition(); }
        }

        public override string ToString()
        {
            if (Equals(Empty))
            {
                return "";
            }

            var charX = (char)('A' - 1 + x);
            var charY = (char)('1' - 1 + y);

            return new string(new[] { charX, charY });
        }

        public static ChessPosition Parse(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return Empty;
            }

            if (value.Length != 2)
            {
                throw new ArgumentException(InvalidStringMessage);
            }

            value = value.ToUpper();
            var charX = value[0];
            var charY = value[1];

            var x = charX - 'A' + 1;
            var y = charY - '1' + 1;

            if (!IsValid(x) || !IsValid(y))
            {
                throw new ArgumentException(InvalidStringMessage);
            }

            return new ChessPosition(x, y);
        }

        private readonly int x;
        private readonly int y;

        private static bool IsValid(int value)
        {
            return value >= MinValue && value <= MaxValue;
        }

        private const string InvalidStringMessage = "Invalid chess position string.";

        private static string GetInvalidValueMessage(string argumentName)
        {
            return string.Format("{0} must be between {1} and {2}.", argumentName, MinValue, MaxValue);
        }
    }
}
