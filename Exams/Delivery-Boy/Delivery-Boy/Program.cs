namespace Delivery_Boy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size =  Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            char[,] field = new char[size[0], size[1]];

            int delBoyRow = 0;
            int delBoyCol = 0;            

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] fieldInpt = Console.ReadLine()!.ToCharArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = fieldInpt[col];

                    if (field[row, col] == 'B')
                    {
                        delBoyRow = row;
                        delBoyCol = col;
                    }
                }
            }

            int startPostionRow = delBoyRow;
            int startPostionCol = delBoyCol;

            bool isDelivered = true;

            string directions;            
            
            while ((directions = Console.ReadLine()!)!= null)
            {
                
                int nextRow = 0;
                int nextCol = 0;

                switch(directions)
                {
                    case "up":
                        nextRow = -1;
                        if (!isInRenage(field, delBoyRow - nextRow, delBoyCol))
                        {
                            isDelivered = false;
                            break;
                        }
                        break;

                    case "down":
                        nextRow = 1;
                        if (!isInRenage(field, delBoyRow + nextRow, delBoyCol))
                        {
                            isDelivered = false;
                            break;
                        }                      
                        break;

                    case "left":
                        nextCol = -1;
                        if (!isInRenage(field, delBoyRow, delBoyCol-delBoyCol))
                        {
                            isDelivered = false;
                            break;
                        }                    
                        break;

                    case "right":
                        nextCol = 1;
                        if (!isInRenage(field, delBoyRow, delBoyCol + nextCol))
                        {
                            isDelivered = false;
                            break;
                        }                        
                        break;
                }
                
                if (!isDelivered)
                {
                    Console.WriteLine("The delivery is late. Order is canceled.");
                    break;
                }
                else
                {
                    if (field[delBoyRow+nextRow,delBoyCol+nextCol] == '*')
                    {
                        continue;
                    }

                    delBoyCol+= nextCol;
                    delBoyRow += nextRow;
                }         

                if (field[delBoyRow,delBoyCol] == 'R')
                {
                    field[delBoyRow, delBoyCol] = 'P';
                    Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                }
                else if (field[delBoyRow,delBoyCol] == 'A')
                {
                    field[delBoyRow, delBoyCol] = 'P';
                }
                else
                {
                    field[delBoyRow, delBoyCol] = '.';
                }
            }

            if (isDelivered)
            {
                Console.WriteLine("Pizza is delivered on time! Next order...");
                field[startPostionRow, startPostionCol] = 'B';
                PrintMatrix(field);
            }
        }

        public static void PrintMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLongLength(0); row++)
            {
                for (int col = 0; col < field.GetLongLength(1); col++)
                {

                }
            }
        }

        public static bool isInRenage(char[,] field, int netRow, int netCol)
        {
            return 
                netRow>=0 && netRow<field.GetLength(0) &&
                netCol>=0 && netCol<field.GetLength(1);
        }
    }    
}