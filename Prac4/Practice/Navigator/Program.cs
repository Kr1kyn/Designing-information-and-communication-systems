using System;

namespace Navigator
{
    class Program
    {
        static void Main(string[] args)
        {
            var NewApp = new App("3GIS");

            var route1 = new BikeRoute("By bike");
            var route2 = new SightseeingRoute("See the sights");
            var route3 = new WalkingRoute("Walk");

            NewApp.SetRoute(route1);
            NewApp.ViewMap();

            NewApp.SetRoute(route2);
            NewApp.ViewMap();

            NewApp.SetRoute(route3);
            NewApp.ViewMap();
        }
    }
}
