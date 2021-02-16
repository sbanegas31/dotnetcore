
namespace dotnetcore.operations {

    public static class Aritmetic {

        public static float Sum(float a, float b){
            return (a + b);
        }

        public static float Subtraction(float a, float b){
            return (a - b);
        }

        public static float Multiply(float a, float b){
            return (a * b);
        }

        public static float Divide(float a, float b){
            return (a / b);
        }

        public static bool IsPair(int a){
            if(a % 2 == 0){
                return true;
            }

            return false;
        }
    }
}