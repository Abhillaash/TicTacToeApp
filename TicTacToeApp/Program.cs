using System;
using System.Collections.Generic;

namespace TicTacToeApp
{
    class Program
    {
        static string[] matrixPosition = new string[]{ "0","1","2","3","4","5","6","7","8","9"};
        static int tossWinner,tossLoser;
        

         static void  Main(string[] args)
        {
            
            Random random = new Random();
            Console.WriteLine("Toss For Who will go  first");
            tossWinner = random.Next(1, 3);
            tossLoser = 3 - tossWinner;
            Console.WriteLine($"Player {tossWinner} wins the toss");
            Console.WriteLine($" {matrixPosition[1]}    |   {matrixPosition[2]}    |   {matrixPosition[3]}");
            Console.WriteLine($" ============================");
            Console.WriteLine($" {matrixPosition[4]}    |   {matrixPosition[5]}    |   {matrixPosition[6]}");
            Console.WriteLine($" ============================");
            Console.WriteLine($" {matrixPosition[7]}    |   {matrixPosition[8]}    |   {matrixPosition[9]}");

            while (true)
            {
                
                InputFromUser(tossWinner,"X");
                if (MatchCondition())
                    break;
                
                //ChangeMatrix();
                InputFromUser(tossLoser,"O");
                //ChangeMatrix();
                if (MatchCondition())
                    break;

                if (CheckDraw()==1)
                {
                    Console.WriteLine("Stalemate");
                    break;
                }

            }

        }
        public static  bool MatchCondition()
        {
            if (MatchesX())
            {
                Console.WriteLine($"Player {tossWinner} wins");
                return true;
            }
            if (MatchesO())
            {
                Console.WriteLine($"Player {tossLoser} wins");
                return true;
            }
            return false;
        }
        public static bool MatchesX()
        {
            if (matrixPosition[1]=="X" && matrixPosition[2]=="X" && matrixPosition[3]== "X")
            {
                return true;
            }
            if (matrixPosition[4] == "X" && matrixPosition[5] == "X" && matrixPosition[6] == "X")
            {
                return true;
            }
            if (matrixPosition[7] == "X" && matrixPosition[8] == "X" && matrixPosition[9] == "X")
            {
                return true;
            }
            if (matrixPosition[1] == "X" && matrixPosition[4] == "X" && matrixPosition[7] == "X")
            {
                return true;
            }
            if (matrixPosition[2] == "X" && matrixPosition[5] == "X" && matrixPosition[8] == "X")
            {
                return true;
            }
            if (matrixPosition[3] == "X" && matrixPosition[6] == "X" && matrixPosition[9] == "X")
            {
                return true;
            }
            if (matrixPosition[1] == "X" && matrixPosition[5] == "X" && matrixPosition[9] == "X")
            {
                return true;
            }
            if (matrixPosition[3] == "X" && matrixPosition[5] == "X" && matrixPosition[7] == "X")
            {
                return true;
            }
            return false;
        }
        public static bool MatchesO()
        {
            if (matrixPosition[1] == "O" && matrixPosition[2] == "O" && matrixPosition[3] == "O")
            {
                return true;
            }
            if (matrixPosition[4] == "O" && matrixPosition[5] == "O" && matrixPosition[6] == "O")
            {
                return true;
            }
            if (matrixPosition[7] == "O" && matrixPosition[8] == "O" && matrixPosition[9] == "O")
            {
                return true;
            }
            if (matrixPosition[1] == "O" && matrixPosition[4] == "O" && matrixPosition[7] == "O")
            {
                return true;
            }
            if (matrixPosition[2] == "O" && matrixPosition[5] == "O" && matrixPosition[8] == "O")
            {
                return true;
            }
            if (matrixPosition[3] == "O" && matrixPosition[6] == "O" && matrixPosition[9] == "O")
            {
                return true;
            }
            if (matrixPosition[1] == "O" && matrixPosition[5] == "O" && matrixPosition[9] == "O")
            {
                return true;
            }
            if (matrixPosition[3] == "O" && matrixPosition[5] == "O" && matrixPosition[7] == "O")
            {
                return true;
            }
            return false;
        }
        public static void InputFromUser(int playerNumber,string letter)
        {
            //Console.WriteLine($" {a[1]}    |   {a[2]}    |   {a[3]}");
            //Console.WriteLine($" ============================");
            //Console.WriteLine($" {a[4]}    |   {a[5]}    |   {a[6]}");
            //Console.WriteLine($" ============================");
            //Console.WriteLine($" {a[7]}    |   {a[8]}    |   {a[9]}");

            Console.WriteLine("Choose the Place No. where You want to put : ");
            Console.WriteLine($"Player {playerNumber} : ");
            int positionNumber = Convert.ToInt32(Console.ReadLine());
            
            
            
            
            matrixPosition[positionNumber] = letter;
            Console.WriteLine($" {matrixPosition[1]}    |   {matrixPosition[2]}    |   {matrixPosition[3]}");
            Console.WriteLine($" ============================");
            Console.WriteLine($" {matrixPosition[4]}    |   {matrixPosition[5]}    |   {matrixPosition[6]}");
            Console.WriteLine($" ============================");
            Console.WriteLine($" {matrixPosition[7]}    |   {matrixPosition[8]}    |   {matrixPosition[9]}");





        }
        //public static void ChangeMatrix()
        //{
        //    Console.WriteLine($" {matrixPosition[1]}    |   {matrixPosition[2]}    |   {matrixPosition[3]}");
        //    Console.WriteLine($" ============================");
        //    Console.WriteLine($" {matrixPosition[4]}    |   {matrixPosition[5]}    |   {matrixPosition[6]}");
        //    Console.WriteLine($" ============================");
        //    Console.WriteLine($" {matrixPosition[7]}    |   {matrixPosition[8]}    |   {matrixPosition[9]}");

            



        //}
        public static int CheckDraw()
        {
            int count = 0;
            for(int i=0;i<matrixPosition.Length;i++)
            {
                if(matrixPosition[i]!="X" && matrixPosition[i]!="O")
                {
                    count += 1;
                }

            }
            return count;
        }
        


    }
}
