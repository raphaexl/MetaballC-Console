namespace Metaballs
{
    class Metabal
    {
        public const int WIDTH = 100;
        public const int HEIGHT = 50;
        public const int BALLS = 6;
        private char[] pixels;
        private Ball[] balls;
        public Metabal(){
            balls = new Ball[BALLS];
            pixels = new char[(WIDTH + 3) * (HEIGHT + 2)];
        }

        private void Init(){
            for (int y = 0; y < HEIGHT + 2; y++){
                for (int x = 0; x < WIDTH + 3; x++){
                    pixels[x + y * (WIDTH + 3)] = ' ';
                }
            }
             for (int y = 0; y < HEIGHT + 2; y++){
                pixels[0 + y * (WIDTH + 3)] = '+';
                pixels[(WIDTH + 1) + y * (WIDTH + 3)] = '+';
                 pixels[(WIDTH + 2) + y * (WIDTH + 3)] = '\n';
            }
            for (int x = 0; x < WIDTH + 2; x++){
                pixels[x + 0 * (WIDTH + 3)] = '+';
                pixels[x + (HEIGHT + 1) * (WIDTH + 3)] = '+';
            }

           for(int i = 0; i < BALLS; i++){
                    balls[i] = new Ball();
            }
        }

        static public float distance(int x1, int y1, int x2, int y2){
            return (System.MathF.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
        }

        static public float distance2(int x1, int y1, int x2, int y2){
            return (((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
        }
        private char evaluate(int x, int y){
            float sum = .0f;

            for (int i = 0; i < BALLS; i++){
               // sum += (balls[i].radius *  balls[i].radius) / distance2(x, y, (int)balls[i].pos.x, (int)balls[i].pos.y);
                sum += (balls[i].radius) / distance(x, y, (int)balls[i].pos.x, (int)balls[i].pos.y);
            }
            sum *= 100;

            System.Func<float, float, float, bool> InBetween = (a, b, value) => {
                return (value >= a && value <= b);
            };
       //     System.Console.WriteLine("sum = {0}", sum);
            if (InBetween(0, 25, sum)){
                return (' ');
            }
            else if (InBetween(25, 30, sum)){
                return ('-');
            }
            else if (InBetween(30, 40, sum)){
                return ('o');
            }
            else if (InBetween(40, 50, sum)){
                return ('#');
            }
            return (' ');
        }

        private void Update(){
            for(int i = 0; i < BALLS; i++){
                    balls[i].Update();
            }
            for (int y = 1; y < HEIGHT; y++){
                for(int x = 1; x < WIDTH; x++){
                    pixels[x + y * (WIDTH + 3)] = evaluate(x, y);
                }
            }
             System.Console.Write(pixels); //For moving Fast
        }
/*Write only Once into the Buffer */
        private void Draw(){
            // for (int y = 0; y < HEIGHT + 2; y++){
            //     for(int x = 0; x < WIDTH + 2; x++){
            //         System.Console.Write(pixels[x + y * (WIDTH + 2)]);
            //     }
            //     System.Console.WriteLine();
            // }
            System.Console.Write(pixels);
        }
        public void Run(){
            Init();
            while (true){
                Update();
                //Draw();
               System.Threading.Thread.Sleep(10);
               System.Console.Clear();
           }
        }
    }
}