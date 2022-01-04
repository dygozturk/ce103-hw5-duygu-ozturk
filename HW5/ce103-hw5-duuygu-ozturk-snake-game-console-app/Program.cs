using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ce103_hw5_snake_dll;

namespace ce103_hw5_snake_app
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ce103_hw5_cs_dll snake = new ce103_hw5_cs_dll();
			snake.welcomeArt();

			do
			{
				switch (snake.mainMenu())
				{
					case 0:
						snake.loadGame();
						break;
					case 1:
						snake.displayHighScores();
						break;
					case 2:
						snake.controls();
						break;
					case 3:
						snake.exitYN();
						break;
				}
			} while (true);
		}
	}
}