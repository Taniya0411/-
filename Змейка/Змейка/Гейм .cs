using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Змейка
{

    class Game //класс, обьединяющий все элементы игры 
    {
        Snake my_snake = new Snake();


        public void Show()
        {
            int k = myPB.Width / sizeX;

            Graphics g = Graphics.FromImage(myPB.Image);
            SolidBrush fon = new SolidBrush(game_color);//берем кисть с фоновым цветом 
            g.FillRectangle(fon, 0, 0, myPB.Width, myPB.Height);

            SolidBrush head = new SolidBrush(Color.Black);
            g.FillRectangle(head, my_snake.body[0].x * k,
            my_snake.body[0].y * k, k, k);

            for (int i = 1; i < my_snake.body.Count; i++)
            {
                SolidBrush snake_color = new SolidBrush(my_snake.my_color);
                g.FillRectangle(snake_color, my_snake.body[i].x * k,
                my_snake.body[i].y * k, k, k);
            }

            for (int i = 0; i < my_blok.body.Count; i++)
            {
                SolidBrush blok_color = new SolidBrush(my_blok.my_color);
                g.FillRectangle(blok_color, my_blok.body[i].x * k,
                my_blok.body[i].y * k, k, k);
            }
            for (int i = 0; i < my_food.body.Count; i++)
            {
                SolidBrush food_color = new SolidBrush(my_food.my_color);
                g.FillRectangle(food_color, my_food.body[i].x * k,
                my_food.body[i].y * k, k, k);
            }
            myPB.Refresh();
        }
            for (int i = 1; i < my_snake.body.Count; i++)
            {
                SolidBrush snake_color = new SolidBrush(my_snake.my_color);
                g.FillRectangle(snake_color, my_snake.body[i].x * k,
                my_snake.body[i].y * k, k, k);
            }
            myPB.Refresh();
        }
    }
    }






}