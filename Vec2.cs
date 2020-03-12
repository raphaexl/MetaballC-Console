namespace Geometry
{
    class Vec2<T>{
        public T x;
        public T y;

        public Vec2(){
            this.x = (T)(object)System.Convert.ChangeType(0.0, typeof(T));
            this.y = (T)(object)System.Convert.ChangeType(0.0, typeof(T));
        }
        public Vec2(T s){
            this.x = s;
            this.y = s;
        }
        public Vec2(T x, T y){
            this.x = x;
            this.y = y;
        }

        public Vec2(Vec2<T> res){
            this.x = res.x;
            this.y = res.y;
        }
/*Weird Methods  but simple*/
        public static Vec2<T> operator - (Vec2<T> vec1){
            double x;
            double y;
            
            double x1 = (double)(object)System.Convert.ChangeType(vec1.x, typeof(double));
            double y1 = (double)(object)System.Convert.ChangeType(vec1.y, typeof(double));
            x = -x1;
            y = -y1;
            return (new Vec2<T>((T)(object)System.Convert.ChangeType(x, typeof(T)), (T)(object)System.Convert.ChangeType(y, typeof(T))));
        }
        public static Vec2<T> operator + (Vec2<T> vec1, Vec2<T> vec2){
            double x;
            double y;
            
            double x1 = (double)(object)System.Convert.ChangeType(vec1.x, typeof(double));
            double y1 = (double)(object)System.Convert.ChangeType(vec1.y, typeof(double));
            double x2 = (double)(object)System.Convert.ChangeType(vec2.x, typeof(double));
            double y2 = (double)(object)System.Convert.ChangeType(vec2.y, typeof(double));
            x = x1 + x2;
            y = y1 + y2;
            return (new Vec2<T>((T)(object)System.Convert.ChangeType(x, typeof(T)), (T)(object)System.Convert.ChangeType(y, typeof(T))));
        }

        public static Vec2<T> operator - (Vec2<T> vec1, Vec2<T> vec2){
            double x;
            double y;
            
            double x1 = (double)(object)System.Convert.ChangeType(vec1.x, typeof(double));
            double y1 = (double)(object)System.Convert.ChangeType(vec1.y, typeof(double));
            double x2 = (double)(object)System.Convert.ChangeType(vec2.x, typeof(double));
            double y2 = (double)(object)System.Convert.ChangeType(vec2.y, typeof(double));
            x = x1 - x2;
            y = y1 - y2;
            return (new Vec2<T>((T)(object)System.Convert.ChangeType(x, typeof(T)), (T)(object)System.Convert.ChangeType(y, typeof(T))));
        }

        public static Vec2<T> operator * (Vec2<T> vec1, Vec2<T> vec2){
            double x;
            double y;
            
            double x1 = (double)(object)System.Convert.ChangeType(vec1.x, typeof(double));
            double y1 = (double)(object)System.Convert.ChangeType(vec1.y, typeof(double));
            double x2 = (double)(object)System.Convert.ChangeType(vec2.x, typeof(double));
            double y2 = (double)(object)System.Convert.ChangeType(vec2.y, typeof(double));
            x = x1 * x2;
            y = y1 * y2;
            return (new Vec2<T>((T)(object)System.Convert.ChangeType(x, typeof(T)), (T)(object)System.Convert.ChangeType(y, typeof(T))));
        }
        public static Vec2<T> operator * (Vec2<T> vec1, T scalar){
            double x;
            double y;
            
            double x1 = (double)(object)System.Convert.ChangeType(vec1.x, typeof(double));
            double y1 = (double)(object)System.Convert.ChangeType(vec1.y, typeof(double));
            double k = (double)(object)System.Convert.ChangeType(scalar, typeof(double));
            x = x1 * k;
            y = y1 * k;
            return (new Vec2<T>((T)(object)System.Convert.ChangeType(x, typeof(T)), (T)(object)System.Convert.ChangeType(y, typeof(T))));
        }
        public static T distance(Vec2<T> vec1, Vec2<T> vec2){
            T dist;
            double x1 = (double)(object)System.Convert.ChangeType(vec1.x, typeof(double));
            double y1 = (double)(object)System.Convert.ChangeType(vec1.y, typeof(double));
            double x2 = (double)(object)System.Convert.ChangeType(vec2.x, typeof(double));
            double y2 = (double)(object)System.Convert.ChangeType(vec2.y, typeof(double));
            dist = (T)(object)System.Convert.ChangeType(System.Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)), typeof(T));
            return (dist);
        }
    }
}