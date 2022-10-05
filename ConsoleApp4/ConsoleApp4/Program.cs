
    class shap
    {
        void triangle()
        {
            int tab = 4;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = tab; j >= 1; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" * ");
                    Console.Write("  ");
                }
                Console.Write('\n');
                tab--;
            }

        }
        
        void rightAngleTraingle()
        {
            for(int i = 0; i <= 4; i++)
            {
                for(int j = 0; j <= 4; j++)
                {
                    Console.Write(" * ");
                }
                Console.Write('\n');
            }
        }

        void Square()
        {
            for(int i=0; i<=4; i++)
            {
                for(int k=0; k<=4; k++)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
            }
        }

        void Rectangle(int h, int w)
        {
            for( int i=0; i<=h; i++)
            {
                for(int k=0; k<w; k++)
            {
                Console.Write(" * ");
            }
                Console.WriteLine();
            }

        }

        static void Main()
        {
            shap shape = new shap();
        //shape.Square();
        Console.Write("Enter 0 for Rectangle\n Enter 1 for Square\n Enter 2 for an Equilateral Triangle ");
            int num = int.Parse(Console.ReadLine());
            if(num == 0)
        {
            shape.Rectangle(4, 3);
        } else if(num == 1)
        {
            shape.Square();
        }else
        {
            shape.rightAngleTraingle();
        }
        }
    }