// See https://aka.ms/new-console-template for more information
namespace Types {
    public class Program
    {
        public static void Main(string[] args)
        {
            byte value = 255;
            byte minimum = 255;
            try
            {
               
                Console.WriteLine(value);
                checked
                {
                    value += minimum;
                    value = (byte)(value + minimum);
                    byte total = (byte)(value + minimum);
                    Console.WriteLine(total);
                }
            }
            catch (OverflowException)
            {

                Console.WriteLine("iki değer toplamı byte olamıyor");
            }

            Direction direction = Direction.Down;
            switch (direction)
            {
                case Direction.Left:
                    break;
                case Direction.Right:
                    break;
                case Direction.Up:
                    break;
                case Direction.Down:
                    break;
                default:
                    break;
            }

            ErkekAkrabalikTipleri erkekAkrabalikTipleri = ErkekAkrabalikTipleri.Abi | ErkekAkrabalikTipleri.Baba | ErkekAkrabalikTipleri.Amca;

            Console.WriteLine(erkekAkrabalikTipleri);

        }

        static byte add(byte a, byte b)
        {
            return (byte)(a + b);
        }
    }
}

