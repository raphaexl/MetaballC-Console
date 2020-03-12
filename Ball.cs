using Geometry;
using Metaballs;
class Ball
{
    const float DEFAULT_RADIUS = 2;
    public Vec2<float> pos;
    public Vec2<float> vel;
    public float radius;
    public Ball(){
        this.radius = DEFAULT_RADIUS;
         System.Func<float, float, float > random = (min, max) => {
            System.Random rand = new System.Random();
            return ((float)rand.NextDouble() * (max - min) + min);
        };
        this.pos = new Vec2<float>(random(1.0f, (float)(Metabal.WIDTH - DEFAULT_RADIUS)),
         random(1.0f, (float)(Metabal.HEIGHT - DEFAULT_RADIUS)));
        this.vel = new Vec2<float>(random(-4.0f, 4.0f), random(-4.0f, 4.0f));
    }
    
    public void Update(){
        this.pos += this.vel;

        double x = (double)(object)System.Convert.ChangeType(pos.x, typeof(double));
        double y = (double)(object)System.Convert.ChangeType(pos.y, typeof(double));
        if (x < 0 || x > (float)Metabal.WIDTH - this.radius){
            this.vel.x =  vel.x * -1.0f;
        }
        if (y < 0 || y > (float)Metabal.HEIGHT - this.radius){
            this.vel.y =  vel.y * -1.0f;
        }
    }
}