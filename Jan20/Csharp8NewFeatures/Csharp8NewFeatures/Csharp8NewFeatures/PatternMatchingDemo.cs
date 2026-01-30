using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class PatternMatchingDemo
    {
        public enum Direction
        {
            Up,
            Down,
            Right,
            Left
        }
        public enum Orientation
        {
            North,
            South,
            East,
            West
        }
        static void ShowPatternMatch()
        {
            #region C#7.0
            //var direction =Direction.Right;
            //Console.WriteLine($"Map view direction is {direction}");
            //Orientation? orientation;
            //switch (direction)
            //{
            //    case Direction.Up:
            //        orientation = Orientation.North;
            //        break;
            //    case Direction.Down:
            //        orientation = Orientation.South;
            //        break;
            //    case Direction.Left:
            //        orientation = Orientation.West;
            //        break;
            //    case Direction.Right:
            //        orientation = Orientation.East;
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}");
            //}
            //Console.WriteLine($"Cardinal Orientation is {orientation}");
            #endregion

            #region C#8.0 Syntax
            var direction = Direction.Left;
            Console.WriteLine($"Map view direction is {direction}");

            Orientation? orientation = direction switch
            {
                Direction.Up => Orientation.North,
                Direction.Down => Orientation.South,
                Direction.Left => Orientation.West,
                Direction.Right => Orientation.East,
                _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}"),
            };
            Console.WriteLine($"Cardinal Orientation is {orientation}");
            #endregion

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day");
            string day = Console.ReadLine();
            //string message = string.Empty;

            #region C#7.0 Syntax
            //switch (day.ToUpper())
            //{
            //    case "SUNDAY":
            //        message = "Weekend";
            //        break;
            //    case "MONDAY":
            //        message = "start of the weekday";
            //        break;
            //    case "FRIDAY":
            //        message = "end of the weekday";
            //        break;
            //    default:
            //        message = "Invalid day";
            //        break;
            //}
            #endregion

            #region C#8.0 Syntax
            var message = day.ToUpper() switch
            {
                "SUNDAY" => "Weekend",
                "MONDAY" => "start of the weekday",
                "FRIDAY" => "end of the weekday",
                _ => "Invalid day"
            };
            #endregion

            ShowPatternMatch();

            Console.WriteLine($"{day} is {message}");
        }
    }
}

