using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw5_snake_dll;

namespace ce103_hw5_snake_test
{
    [TestClass]
    public class UnitTest1
    {

        /* [TestMethod]
         public void collisionSnake_test_1()
         {
             Class1 eat = new Class1();
             int 
         }*/



        [TestMethod]
        public void collisionDetection_test_1()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int consoleWidth = 80;
            int consoleHeight = 80;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 60;
            snakeXY[1, 0] = 70;
            int snakeLength = 60;
            bool situation = eat.collisionDetection(snakeXY, consoleWidth, consoleHeight, snakeLength);
            Assert.AreEqual(false, situation);
        }

        [TestMethod]
        public void collisionDetection_test_2()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int consoleWidth = 20;
            int consoleHeight = 20;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 40;
            snakeXY[1, 0] = 50;
            int snakeLength = 40;
            bool situation = eat.collisionDetection(snakeXY, consoleWidth, consoleHeight, snakeLength);
            Assert.AreEqual(false, situation);
        }

        [TestMethod]
        public void collisionDetection_test_3()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int consoleWidth = 30;
            int consoleHeight = 30;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 10;
            snakeXY[1, 0] = 60;
            int snakeLength = 10;
            bool situation = eat.collisionDetection(snakeXY, consoleWidth, consoleHeight, snakeLength);
            Assert.AreEqual(false, situation);
        }
        [TestMethod]
        public void Eatfood_test_1()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 20;
            snakeXY[1, 0] = 10;
            int[] foodXY = { 5, 5 };
            Assert.AreEqual(false, eat.eatFood(snakeXY, foodXY));
        }
        [TestMethod]
        public void Eatfood_test_2()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 20;
            snakeXY[1, 0] = 10;
            int[] foodXY = { 6, 6 };
            Assert.AreEqual(false, eat.eatFood(snakeXY, foodXY));
        }
        [TestMethod]
        public void Eatfood_test_3()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 20;
            snakeXY[1, 0] = 10;
            int[] foodXY = { 7, 7 };
            Assert.AreEqual(false, eat.eatFood(snakeXY, foodXY));
        }
        [TestMethod]
        public void collisionSnake_test_1()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int x = 80;
            int y = 80;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 70;
            snakeXY[1, 0] = 80;
            int snakeLength = 70;
            bool situation = eat.collisionDetection(snakeXY, x, y, snakeLength);
            Assert.AreEqual(false, situation);
        }
        [TestMethod]
        public void collisionSnake_test_2()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int x = 30;
            int y = 30;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 10;
            snakeXY[1, 0] = 20;
            int snakeLength = 10;
            bool situation = eat.collisionDetection(snakeXY, x, y, snakeLength);
            Assert.AreEqual(false, situation);
        }
        [TestMethod]
        public void collisionSnake_test_3()
        {
            ce103_hw5_cs_dll eat = new ce103_hw5_cs_dll();
            int x = 60;
            int y = 60;
            int[,] snakeXY = new int[2, 310];
            snakeXY[0, 0] = 50;
            snakeXY[1, 0] = 60;
            int snakeLength = 50;
            bool situation = eat.collisionDetection(snakeXY, x, y, snakeLength);
            Assert.AreEqual(false, situation);
        }
    }
}