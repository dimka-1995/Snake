using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreater
    {
        int mapWidht;
        int mapHeight;
        char sym;
        Random random = new Random();

        public FoodCreater(int _mapWidht,int _mapHeight,char _sym)
        {
            mapWidht = _mapWidht;
            mapHeight = _mapHeight;
            sym = _sym;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
