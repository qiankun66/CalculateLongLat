 class Program
    {
        static void Main(string[] args)
        {
            Print();
        }

        public static void Print()
        {
            Console.WriteLine("输入A点纬度：");
            double lat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入A点经度：");
            double lng1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入B点纬度：");
            double lat2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入B点经度：");
            double lng2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("两点相距："+GetDistance(lat1, lng1, lat2, lng2));
            Console.WriteLine("点击任意继续！输入exit退出！");
            if (Console.ReadLine()!="exit")
            {
                Print();
            }
        }

        private const double EARTH_RADIUS = 6378.137;//地球半径
        private static double rad(double d)
        {
            return d * Math.PI / 180.0;
        }
        public static double GetDistance(double lat1, double lng1, double lat2, double lng2)
        {
            double radLat1 = rad(lat1);
            double radLat2 = rad(lat2);
            double a = radLat1 - radLat2;
            double b = rad(lng1) - rad(lng2);

            double s = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2) +
             Math.Cos(radLat1) * Math.Cos(radLat2) * Math.Pow(Math.Sin(b / 2), 2)));
            s = s * EARTH_RADIUS;
            s = Math.Round(s * 10000) / 10000;
            return s;
        }
    }
