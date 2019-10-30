using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using System.Collections;
using System.IO;
using System.Xml;


namespace myPaint
{

    public class anBrush
    {
        public Bitmap myBrush;

        private bool IsErase = false; // вказує на "стирачку"

        public bool IsBrushErase() // функция перевіряє на "стирачку"
        {
            return IsErase;
        }

        public anBrush(int Value, bool Special) // пераметр Value переда або розмір стандартного пензлика або номер спеціального
        {
            if (!Special) // стандартний "квадратний" пензлик 
            {
                myBrush = new Bitmap(Value, Value);

                for (int ax = 0; ax < Value; ax++)
                {
                    for (int bx = 0; bx < Value; bx++)
                    {
                        myBrush.SetPixel(0, 0, Color.Black);
                    }
                }
                IsErase = false;
            }
            else
            {
                switch (Value)
                {
                    default: // по замовчуванню хрестик 3х3
                    {
                        myBrush = new Bitmap(3, 3);
                        for (int ax = 0; ax < 3; ax++)
                        {
                            for (int bx = 0; bx < 3; bx++)
                            {
                                myBrush.SetPixel(ax, bx, Color.Red);
                            }
                        }
                        myBrush.SetPixel(0, 1, Color.Black);
                        myBrush.SetPixel(1, 0, Color.Black);
                        myBrush.SetPixel(1, 1, Color.Black);
                        myBrush.SetPixel(1, 2, Color.Black);
                        myBrush.SetPixel(2, 1, Color.Black);
                        IsErase = false;
                        break;
                    }
                    case 1: // стирачка 5х5
                    {
                        myBrush = new Bitmap(5, 5);
                        for (int ax = 0; ax < 5; ax++)
                        {
                            for (int bx = 0; bx < 5; bx++)
                            {
                                myBrush.SetPixel(ax, bx, Color.Black);
                            }
                        }
                        IsErase = true;
                        break;
                    }
                    case 2: // стирачка 10х10
                    {
                        myBrush = new Bitmap(10, 10);
                        for (int ax = 0; ax < 10; ax++)
                        {
                            for (int bx = 0; bx < 10; bx++)
                            {
                                myBrush.SetPixel(ax, bx, Color.Black);
                            }
                        }
                        IsErase = true;
                        break;
                    }
                    case 3: // стирачка 20х20
                    {
                        myBrush = new Bitmap(20, 20);
                        for (int ax = 0; ax < 20; ax++)
                        {
                            for (int bx = 0; bx < 20; bx++)
                            {
                                myBrush.SetPixel(ax, bx, Color.Black);
                            }
                        }
                        IsErase = true;
                        break;
                    }
                    case 4: // хрестик 4х4
                    {
                        myBrush = new Bitmap(4, 4);
                        for (int ax = 0; ax < 4; ax++)
                        {
                            for (int bx = 0; bx < 4; bx++)
                            {
                                myBrush.SetPixel(ax, bx, Color.Red);
                            }
                        }
                        myBrush.SetPixel(0, 1, Color.Black);
                        myBrush.SetPixel(0, 2, Color.Black);
                        myBrush.SetPixel(1, 0, Color.Black);
                        myBrush.SetPixel(1, 1, Color.Black);
                        myBrush.SetPixel(1, 2, Color.Black);
                        myBrush.SetPixel(1, 3, Color.Black);
                        myBrush.SetPixel(2, 0, Color.Black);
                        myBrush.SetPixel(2, 1, Color.Black);
                        myBrush.SetPixel(2, 2, Color.Black);
                        myBrush.SetPixel(2, 3, Color.Black);
                        myBrush.SetPixel(3, 1, Color.Black);
                        myBrush.SetPixel(3, 2, Color.Black);
                        IsErase = false;
                        break;
                    }
                    case 5: // хрестик 5х5
                    {
                         myBrush = new Bitmap(5, 5);
                         for (int ax = 0; ax < 5; ax++)
                         {
                             for (int bx = 0; bx < 5; bx++)
                             {
                                 myBrush.SetPixel(ax, bx, Color.Red);
                             }
                         }
                         myBrush.SetPixel(0, 2, Color.Black);
                         myBrush.SetPixel(1, 2, Color.Black);
                         myBrush.SetPixel(2, 0, Color.Black);
                         myBrush.SetPixel(2, 1, Color.Black);
                         myBrush.SetPixel(2, 2, Color.Black);
                         myBrush.SetPixel(2, 3, Color.Black);
                         myBrush.SetPixel(2, 4, Color.Black);
                         myBrush.SetPixel(3, 2, Color.Black);
                         myBrush.SetPixel(4, 2, Color.Black);
                         IsErase = false;
                         break;
                    }
                    case 6: // правий слеш 3х3
                    {
                         myBrush = new Bitmap(3, 3);
                         for (int ax = 0; ax < 3; ax++)
                            {
                                for (int bx = 0; bx < 3; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 2, Color.Black);
                         myBrush.SetPixel(1, 1, Color.Black);
                         myBrush.SetPixel(2, 0, Color.Black);
                         IsErase = false;
                         break;
                    }
                    case 7: // правий слеш 4х4
                    {
                         myBrush = new Bitmap(4, 4);
                         for (int ax = 0; ax < 4; ax++)
                            {
                                for (int bx = 0; bx < 4; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 3, Color.Black);
                         myBrush.SetPixel(1, 2, Color.Black);
                         myBrush.SetPixel(2, 1, Color.Black);
                         myBrush.SetPixel(3, 0, Color.Black);
                         IsErase = false;
                         break;
                    }
                    case 8: // правий слеш 5х5
                    {
                         myBrush = new Bitmap(5, 5);
                         for (int ax = 0; ax < 5; ax++)
                            {
                                for (int bx = 0; bx < 5; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 4, Color.Black);
                         myBrush.SetPixel(1, 3, Color.Black);
                         myBrush.SetPixel(2, 2, Color.Black);
                         myBrush.SetPixel(3, 1, Color.Black);
                         myBrush.SetPixel(4, 0, Color.Black);
                         IsErase = false;
                         break;
                    }
                    case 9: // лівий слеш 3х3
                    {
                         myBrush = new Bitmap(3, 3);
                         for (int ax = 0; ax < 3; ax++)
                            {
                                for (int bx = 0; bx < 3; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 2, Color.Black);
                         myBrush.SetPixel(1, 1, Color.Black);
                         myBrush.SetPixel(2, 0, Color.Black);
                         IsErase = false;
                         break;
                    }
                    case 10: // лівий слеш 4х4
                    {
                         myBrush = new Bitmap(4, 4);
                         for (int ax = 0; ax < 4; ax++)
                            {
                                for (int bx = 0; bx < 4; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 0, Color.Black);
                         myBrush.SetPixel(1, 1, Color.Black);
                         myBrush.SetPixel(2, 2, Color.Black);
                         myBrush.SetPixel(3, 3, Color.Black);
                         IsErase = false;
                         break;
                    }
                    case 11: // лівий слеш 5х5
                    {
                         myBrush = new Bitmap(5, 5);
                         for (int ax = 0; ax < 5; ax++)
                            {
                                for (int bx = 0; bx < 5; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 0, Color.Black);
                         myBrush.SetPixel(1, 1, Color.Black);
                         myBrush.SetPixel(2, 2, Color.Black);
                         myBrush.SetPixel(3, 3, Color.Black);
                         myBrush.SetPixel(4, 4, Color.Black);
                         IsErase = false;
                         break;
                    }

                    case 12: // X 3х3
                    {
                         myBrush = new Bitmap(3, 3);
                         for (int ax = 0; ax < 3; ax++)
                            {
                                for (int bx = 0; bx < 3; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 0, Color.Black);
                         myBrush.SetPixel(0, 2, Color.Black);
                         myBrush.SetPixel(1, 1, Color.Black);
                         myBrush.SetPixel(2, 0, Color.Black);
                         myBrush.SetPixel(2, 2, Color.Black);
                         IsErase = false;
                         break;
                    }
                    case 13: // X 4х4
                    {
                         myBrush = new Bitmap(4, 4);
                         for (int ax = 0; ax < 4; ax++)
                            {
                                for (int bx = 0; bx < 4; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 0, Color.Black);
                         myBrush.SetPixel(0, 3, Color.Black);
                         myBrush.SetPixel(1, 1, Color.Black);
                         myBrush.SetPixel(1, 2, Color.Black);
                         myBrush.SetPixel(2, 1, Color.Black);
                         myBrush.SetPixel(2, 2, Color.Black);
                         myBrush.SetPixel(3, 0, Color.Black);
                         myBrush.SetPixel(3, 3, Color.Black);
                         IsErase = false;
                         break;
                    }
                    case 14: // X 5х5
                    {
                         myBrush = new Bitmap(5, 5);
                         for (int ax = 0; ax < 5; ax++)
                            {
                                for (int bx = 0; bx < 5; bx++)
                                {
                                    myBrush.SetPixel(ax, bx, Color.Red);
                                }
                            }
                         myBrush.SetPixel(0, 0, Color.Black);
                         myBrush.SetPixel(0, 4, Color.Black);
                         myBrush.SetPixel(1, 1, Color.Black);
                         myBrush.SetPixel(1, 3, Color.Black);
                         myBrush.SetPixel(2, 2, Color.Black);
                         myBrush.SetPixel(3, 1, Color.Black);
                         myBrush.SetPixel(3, 3, Color.Black);
                         myBrush.SetPixel(4, 0, Color.Black);
                         myBrush.SetPixel(4, 4, Color.Black);
                         IsErase = false;
                         break;
                    }
                }
            }
        }

        public anBrush(string FromFile) // реалізація завантажуваних з файлів пензликів 
        {
            var fsBrush = new FileStream(FromFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            myBrush = new Bitmap(fsBrush);
            fsBrush.Dispose();
        }
    }

    public class anLayer
    {
        public int Width, Heigth; // разміри порту виводу (елемента SimpleOpenGLControl)

        private int[,,] DrawPlace; // масив (малюнок) координати пікселя и його колір
        
        private bool isVisible; // видимість шару true - видимий, false - невидимий

        private Color ActiveColor; // поточний колір

        public int[,,] GetDrawPlace() // функція отримання масиву растрових даних шару
        {
            return DrawPlace;
        }

        private int ListNom; // номер дисплейного списку для данного шару
        
        public anLayer(int s_W, int s_H) // конструктор класу
        {
            Width = s_W; // розмір малюнка
            Heigth = s_H;
            DrawPlace = new int[Width, Heigth, 4]; // створюєм масив, "точка", 3 сладові кольору + 4 піксель прозорий
            for (int ax = 0; ax < Width; ax++) // створюєм "прозорий" масив
            {
                for (int bx = 0; bx < Heigth; bx++)
                {
                    DrawPlace[ax, bx, 3] = 1;
                }
            }
            isVisible = true;
            ListNom = Gl.glGenLists(1); // номер вільного дисплейного списку
            ActiveColor = Color.Black;
        }

        public void SetVisibility(bool visiblityState) // метод установки режиму видимості шару
        {
            isVisible = visiblityState;
        }
        
        public bool GetVisibility() // функція отримання даних про видимість шару
        {
            return isVisible;
        }

        public void SetColor(Color NewColor) // метод установки поточного кольору
        {
            ActiveColor = NewColor;
        }

        public Color GetColor() // функція отримання активного кольору
        {
            return ActiveColor;
        }

        public void Draw(anBrush BR, int x, int y) // метод малювання отримує в параметрах інструмент и координаты де треба перемалювать
        {
            int real_pos_draw_start_x = x - BR.myBrush.Width / 2; // визначаємо позицію початку малювання
            int real_pos_draw_start_y = y - BR.myBrush.Height / 2;

            if (real_pos_draw_start_x < 0) real_pos_draw_start_x = 0; // коригуємо для недопущення виходу за межі масиву
            if (real_pos_draw_start_y < 0) real_pos_draw_start_y = 0;
         
            int boundary_x = real_pos_draw_start_x + BR.myBrush.Width;
            int boundary_y = real_pos_draw_start_y + BR.myBrush.Height;
                        
            if(boundary_x > Width) boundary_x = Width;
            if(boundary_y > Heigth) boundary_y = Heigth;

            int count_x = 0, count_y = 0; // лічильник масиву маски пензлика
            
            for (int ax = real_pos_draw_start_x; ax < boundary_x; ax++, count_x++) // цикл з аналізом зміщення пензлика и коорекції для недопущення вихода за межі масиву
            {
                count_y = 0;
                for (int bx = real_pos_draw_start_y; bx < boundary_y; bx++, count_y++)
                {
                    if (BR.IsBrushErase()) // чи нестирачка?
                    {
                        Color ret = BR.myBrush.GetPixel(count_x, count_y);
                        if (!(ret.R == 255 && ret.G == 0 && ret.B == 0)) // аналізуємо маску пензлика на червоний колір
                        {
                            DrawPlace[ax, bx, 3] = 1; // точка стає прозора
                        }
                    }
                    else
                    {
                        Color ret = BR.myBrush.GetPixel(count_x, count_y);
                        if (!(ret.R == 255 && ret.G == 0 && ret.B == 0)) // аналізуємо маску пензлика на червоний колір
                        {
                            DrawPlace[ax, bx, 0] = ActiveColor.R; // заповняєм дані про піксель 
                            DrawPlace[ax, bx, 1] = ActiveColor.G; // про піксель з маски пензлика
                            DrawPlace[ax, bx, 2] = ActiveColor.B; // використовуючи активний колір
                            DrawPlace[ax, bx, 3] = 0;
                        }
                    }
                }
            }
        }

        public void ClearList() // метод видалення дисплейного списку шарів
        {
            if (Gl.glIsList(ListNom) == Gl.GL_TRUE) // перевіряєм існування і видаляєм
            {
                Gl.glDeleteLists(ListNom,1);
            }
        }

        public void CreateNewList() // метод створення дисплейного списка
        {
            if (Gl.glIsList(ListNom) == Gl.GL_TRUE) // перевіряєм існування і видаляєм
            {
                Gl.glDeleteLists(ListNom,1);
                ListNom = Gl.glGenLists(1); // генеруєм новий
            }
            Gl.glNewList(ListNom, Gl.GL_COMPILE); // створюєм дисплейный список
            RenderImage(false); // візуалізація
            Gl.glEndList();
        }

        public void RenderImage(bool FromList) // метод візуалізації шару
        {
            if (FromList) // вказана візуалізація із дисплейного списку, шар не активний
            {
                Gl.glCallList(ListNom); // викликаєм дисплейный список
            }
            else // шар активний, проводимо візуалізацію
            {
                int count = 0; // лічильник елементів що підлягають візуалізації
                
                for (int ax = 0; ax < Width; ax++) // проходимо по всіх точках малюнка
                {
                    for (int bx = 0; bx < Heigth; bx++)
                    {
                        if (DrawPlace[ax, bx, 3] != 1) // точка (ax,bx) не прозора
                        {
                            count++;
                        }
                    }
                }
                int[] arr_date_vertex = new int[count * 2]; // створюемо масив (x,y) точок що відображаються
                float[] arr_date_colors = new float[count * 3]; // створюемо масив (R,G,B) точок що відображаються
                int now_element = 0;
                for (int ax = 0; ax < Width; ax++)
                {
                    for (int bx = 0; bx < Heigth; bx++)
                    {
                        if (DrawPlace[ax, bx, 3] != 1)
                        {
                            arr_date_vertex[now_element * 2] = ax;
                            arr_date_vertex[now_element * 2 + 1] = bx;
                            arr_date_colors[now_element * 3] = (float)DrawPlace[ax, bx, 0] / 255.0f;
                            arr_date_colors[now_element * 3 + 1] = (float)DrawPlace[ax, bx, 1] / 255.0f;
                            arr_date_colors[now_element * 3 + 2] = (float)DrawPlace[ax, bx, 2] / 255.0f;
                            now_element++;
                        }
                    }
                }
                Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY); // вмикаємо функцію використання масивів вершин
                Gl.glEnableClientState(Gl.GL_COLOR_ARRAY);  // вмикаємо функцію використання масивів кольорів
                Gl.glColorPointer(3, Gl.GL_FLOAT, 0, arr_date_colors); //передаем масиви в OpenGL
                Gl.glVertexPointer(2, Gl.GL_INT, 0, arr_date_vertex);
                Gl.glDrawArrays(Gl.GL_POINTS, 0, count);
                Gl.glDisableClientState(Gl.GL_VERTEX_ARRAY); // вимикаємо функцію використання масивів вершин
                Gl.glDisableClientState(Gl.GL_COLOR_ARRAY);  // вимикаємо функцію використання масивів кольорів
            }
        }

        public void Fill(Color f_color)
        {
            for (int Y = 0; Y < Heigth; Y++)
            {
                for (int X = 0; X < Width; X++)
                {
                    DrawPlace[X, Y, 3] = 0;
                    DrawPlace[X, Y, 0] = f_color.R;
                    DrawPlace[X, Y, 1] = f_color.G;
                    DrawPlace[X, Y, 2] = f_color.B;
                }
            }
        }

        public void Clean()
        {
            for (int Y = 0; Y < Heigth; Y++)
            {
                for (int X = 0; X < Width; X++)
                {
                    DrawPlace[X, Y, 3] = 1;
                    DrawPlace[X, Y, 0] = 0;
                    DrawPlace[X, Y, 1] = 0;
                    DrawPlace[X, Y, 2] = 0;
                }
            }
        }

        public void FromArrayboard(int[,,] arr_board)
        {
            for (int Y = 0; Y < Heigth; Y++)
            {
                for (int X = 0; X < Width; X++)
                {
                    if (arr_board[X, Y, 3] == 0)
                    {
                        DrawPlace[X, Y, 0] = arr_board[X, Y, 0];
                        DrawPlace[X, Y, 1] = arr_board[X, Y, 1];
                        DrawPlace[X, Y, 2] = arr_board[X, Y, 2];
                    }
                }
            }
        }

        public void AllFromArrayboard(int[,,] arr_board)
        {
            for (int Y = 0; Y < Heigth; Y++)
            {
                for (int X = 0; X < Width; X++)
                {
                    if (arr_board[X, Y, 3] == 0)
                    {
                        DrawPlace[X, Y, 3] = arr_board[X, Y, 3];
                        DrawPlace[X, Y, 0] = arr_board[X, Y, 0];
                        DrawPlace[X, Y, 1] = arr_board[X, Y, 1];
                        DrawPlace[X, Y, 2] = arr_board[X, Y, 2];
                    }
                }
            }
        }

        public void Inverse()
        { 
            for ( int Y = 0; Y < Heigth; Y++)
            {
                for ( int X = 0; X < Width; X++)
                {
                    DrawPlace[X, Y, 0] = 255-DrawPlace[X, Y, 0];
                    DrawPlace[X, Y, 1] = 255-DrawPlace[X, Y, 1];
                    DrawPlace[X, Y, 2] = 255-DrawPlace[X, Y, 2];
                }
            }
        }

        public void CorrectRGB(int corr_red, int corr_green, int corr_blue)
        {
            for (int Y = 0; Y < Heigth; Y++)
            {
                for (int X = 0; X < Width; X++)
                {
                    DrawPlace[X, Y, 0] = ((DrawPlace[X, Y, 0] + corr_red > 255) ? 255 : DrawPlace[X, Y, 0] + corr_red);
                    DrawPlace[X, Y, 1] = ((DrawPlace[X, Y, 1] + corr_green > 255) ? 255 : DrawPlace[X, Y, 1] + corr_green);
                    DrawPlace[X, Y, 2] = ((DrawPlace[X, Y, 2] + corr_blue > 255) ? 255 : DrawPlace[X, Y, 2] + corr_blue);
                }
            }
        }


        public void ToGrey()
        {
            int greycolor;
            for (int Y = 0; Y < Heigth; Y++)
            {
                for (int X = 0; X < Width; X++)
                {
                    greycolor = (DrawPlace[X, Y, 0] + DrawPlace[X, Y, 1] + DrawPlace[X, Y, 2]) / 3;
                    DrawPlace[X, Y, 0] = greycolor;
                    DrawPlace[X, Y, 1] = greycolor;
                    DrawPlace[X, Y, 2] = greycolor;
                }
            }
        }

        public void Sepia()
        {
            float[] resault_RGB = new float[3];
            for (int Y = 0; Y < Heigth; Y++)
            {
                for (int X = 0; X < Width; X++)
                {
                    resault_RGB[0] = DrawPlace[X, Y, 0] * 0.393f + DrawPlace[X, Y, 1] * 0.769f + DrawPlace[X, Y, 2] * 0.189f;
                    resault_RGB[1] = DrawPlace[X, Y, 0] * 0.349f + DrawPlace[X, Y, 1] * 0.686f + DrawPlace[X, Y, 2] * 0.168f;
                    resault_RGB[2] = DrawPlace[X, Y, 0] * 0.272f + DrawPlace[X, Y, 1] * 0.534f + DrawPlace[X, Y, 2] * 0.131f;
                    DrawPlace[X, Y, 0] = (int)((resault_RGB[0] > 255) ? 255 : resault_RGB[0]);
                    DrawPlace[X, Y, 1] = (int)((resault_RGB[1] > 255) ? 255 : resault_RGB[1]);
                    DrawPlace[X, Y, 2] = (int)((resault_RGB[2] > 255) ? 255 : resault_RGB[2]);
                }
            }
        }

        /* Опис методу ApplyEffect:
         * Effect_Matrix - матриця для обробки "ефекту"
         * Correction - корекція кольору пікселя після обробки
         * Intensification - коефіцієнт підсилення "ефекту"
         * need_correction - необхідність коригування пікселя після проходу "ефекту", відносно кількостей проходу */
        public void ApplyEffect(float[] Effect_Matrix, int Correction, float Intensification, bool need_correction)
        {
            float [] resault_RGB = new float [3];  // додатковий масив для отримання результату обробки пікселя
            int count = 0; // лічильник кількості обробок
            for ( int Y = 0; Y < Heigth; Y++) // проходим циклом по всіх пікселях шару
            {
                for ( int X = 0; X < Width; X++)
                {  
                    for ( int c = 0, ax = 0, bx = 0; c < 3; c++) // + цикл по 0-2, тобто складовим RGB)
                    {
                        resault_RGB[c] = 0;
                        count = 0;
                        for (bx = -1; bx < 2; bx++) // захоплення області 3х3 навколо пікселя
                        {
                            for (ax = -1; ax < 2; ax++)
                            {
                                if (X + ax < 0 || X + ax > Width-1 || Y + bx < 0 || Y + bx > Heigth-1) // якщо точка на межі малюнку
                                {   
                                    resault_RGB[c] += ( float )(DrawPlace[X, Y, c]) * Effect_Matrix[count] * Intensification + Correction;
                                    count++;
                                    continue; // продовжуємо цикл
                                }
                                resault_RGB[c] += ( float )(DrawPlace[X + ax, Y + bx, c]) * Effect_Matrix[count] * Intensification + Correction;
                                count++;
                            }
                        }
                    }
                    for ( int c = 0; c < 3; c++) 
                    {
                        if ( count != 0 && need_correction) // якщо необхідно, коригуем колір RGB слідкуючи за виходом за межі (0-255)
                        {
                            resault_RGB[c] /= count;
                        }
                        if (resault_RGB[c] < 0)
                        {
                            resault_RGB[c] = 0;
                        }
                        if (resault_RGB[c] > 255)
                        {
                            resault_RGB[c] = 255;
                        }
                        DrawPlace[X, Y, c] = ( int )resault_RGB[c]; // запис в масив шару нового значення
                    }
                }
            }
        }
    }

    public class anEngine // основний клас що реалізує логіку роботи редактора
    {
        private int picture_size_x, picture_size_y; // размеры изображения

        //private int scroll_x, scroll_y; // положення прокрутки нереалізовано

        private int screen_width, screen_height; // размір SimpleOpenGLControl

        private int ActiveLayerNom; // номер активного шару

        private ArrayList Layers = new ArrayList(); // масив шарів

        private anBrush standartBrush; // активний пензлик

        private Color LastColorInUse; // встановлений колір

        private int[,,] Arrayboard; // масив - "буфер обміну"

        public anEngine(int size_x, int size_y, int screen_w, int screen_h) // конструктор класу
        {
            picture_size_x = size_x;
            picture_size_y = size_y;
            screen_width = screen_w;
            screen_height = screen_h;
            //scroll_x = 0; // прокрутка
            //scroll_y = 0; // нереалізована
            Layers.Add(new anLayer(picture_size_x, picture_size_y)); // добавим нульовий шар
            ActiveLayerNom = 0;
            standartBrush = new anBrush(3, false); // ініціалізація інструменту по замовчуванню
        }

        public Bitmap GetFinalImage() // функція отримання фінального зображення
        {
            Bitmap resaultBitmap = new Bitmap(picture_size_x, picture_size_y);
            for (int ax = 0; ax < Layers.Count; ax++)
            {
                int[,,] tmp_layer_data = ((anLayer)Layers[ax]).GetDrawPlace();
                for (int a = 0; a < picture_size_x; a++) // 2 цикли по пікселях шару
                {
                    for (int b = 0; b < picture_size_y; b++)
                    {
                        if (tmp_layer_data[a, b, 3] != 1) // якщо піксель не помечений "прозорий"
                        {
                            resaultBitmap.SetPixel(a, b, Color.FromArgb(tmp_layer_data[a, b, 0], tmp_layer_data[a, b, 1], tmp_layer_data[a, b, 2]));
                        }
                        else
                        {
                            if (ax == 0) // нульовий шар зафарбовуємо білым відсутні піксели
                            {
                                resaultBitmap.SetPixel(a, b, Color.FromArgb(255, 255, 255));
                            }
                        }
                    }
                }

            }
            resaultBitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
            return resaultBitmap;
        }

        public void SetImageToMainLayer(Bitmap layer) // метод отримання зображения для головного шару
        {
            layer.RotateFlip(RotateFlipType.Rotate180FlipX);
            for (int ax = 0; ax < layer.Width; ax++)
            {
                for (int bx = 0; bx < layer.Height; bx++)
                {
                    SetColor(layer.GetPixel(ax, bx));
                    Drawing(ax, bx);
                }
            }
        }

        public void SetActiveLayerNom(int num) // метод установки номера активного шару
        {
            ((anLayer)Layers[ActiveLayerNom]).CreateNewList();
            ((anLayer)Layers[num]).SetColor(((anLayer)Layers[ActiveLayerNom]).GetColor());
            ActiveLayerNom = num;
        }

        public void SetStandartBrush(int SizeBrush) // метод установки стандартного пензлика по розміру
        {
            standartBrush = new anBrush(SizeBrush, false);
        }

        public void SetSpecialBrush(int Num) // метод установки спеціального пензлика
        {
            standartBrush = new anBrush(Num, true);
        }

        public void SetBrushFromFile(string FileName) // метод установка пензлика з файлу
        {
            standartBrush = new anBrush(FileName);
        }


        public void SetWisibilityLayerNom(int nom, bool visible)
        {
            // установка видимості шару не реалізована
        }


        public void Drawing(int x, int y) // метод малювання трансляція координат
        {
            ((anLayer)Layers[ActiveLayerNom]).Draw(standartBrush, x, y);
        }

        public void SetColor(Color NewColor) // метод встановлення активного кольору
        {
            ((anLayer)Layers[ActiveLayerNom]).SetColor(NewColor);
            LastColorInUse = NewColor;
        }

        public void SwapImage() // візуалізація
        {
            for (int ax = 0; ax < Layers.Count; ax++)
            {
                if (ax == ActiveLayerNom)
                {
                    ((anLayer)Layers[ax]).RenderImage(false);
                }
                else
                {
                    ((anLayer)Layers[ax]).RenderImage(true);
                }
            }
        }

        public void AddLayer() // метод додавання шару
        {
            int AddingLayer = Layers.Add(new anLayer(picture_size_x, picture_size_y));
            SetActiveLayerNom(AddingLayer);
        }

        public void RemoveLayer(int num) // метод видалення шару
        {
            if (num < Layers.Count && num >= 0)
            {
                SetActiveLayerNom(0);
                ((anLayer)Layers[num]).ClearList();
                Layers.RemoveAt(num);
            }
        }

        public void FillLayer(Color FillColor) // метод "заливки" поточного шару
        {
            ((anLayer)Layers[ActiveLayerNom]).Fill(FillColor);
        }

        public void CleanLayer() // метод очистки поточного шару
        {
            ((anLayer)Layers[ActiveLayerNom]).Clean();
        }

        public void LayerToArrayboard() // метод копіювання даних шару до масиву-"буфера обміну"
        {
            int[,,] arr_temp = ((anLayer)Layers[ActiveLayerNom]).GetDrawPlace();
            Arrayboard = new int[picture_size_x, picture_size_y, 4];
            for (int Y = 0; Y < picture_size_y; Y++)
            {
                for (int X = 0; X < picture_size_x; X++)
                {
                    Arrayboard[X, Y, 3] = arr_temp[X, Y, 3];
                    Arrayboard[X, Y, 0] = arr_temp[X, Y, 0];
                    Arrayboard[X, Y, 1] = arr_temp[X, Y, 1];
                    Arrayboard[X, Y, 2] = arr_temp[X, Y, 2];
                }
            }
        }

        public void AllLayerFromArrayboard() // функция вставки даних шару з масиву-"буфера обміну"
        {
            ((anLayer)Layers[ActiveLayerNom]).AllFromArrayboard(Arrayboard);
        }

        public void LayerFromArrayboard() // функция вставки в непрозорі точки шару даних з масиву-"буфера обміну"
        {
            ((anLayer)Layers[ActiveLayerNom]).FromArrayboard(Arrayboard);
        }

        public void EffectFilter(int FilterID)
        {
            switch (FilterID)
            {
                case 1: // інверсія кольору
                    {
                        ((anLayer)Layers[ActiveLayerNom]).Inverse();
                        break;
                    }
                case 2: // відтінки сірого
                    {
                        ((anLayer)Layers[ActiveLayerNom]).ToGrey();
                        break;
                    }
                case 3: // ефект "сепія"
                    {
                        ((anLayer)Layers[ActiveLayerNom]).Sepia();
                        break;
                    }
                case 4: // ефект розмиття
                    {
                        float[] me = new float[9];
                        me[0] = 0.05f;
                        me[1] = 0.05f;
                        me[2] = 0.05f;
                        me[3] = 0.05f; //  0.05 0.05 0.05
                        me[4] = 0.6f;  //  0.05 0.60 0.05
                        me[5] = 0.05f; //  0.05 0.05 0.05
                        me[6] = 0.05f;
                        me[7] = 0.05f;
                        me[8] = 0.05f;
                        ((anLayer)Layers[ActiveLayerNom]).ApplyEffect(me, 0, 1, false);
                        break;
                    }
                case 5: // ефект підвищення різкості
                    {
                        float[] me = new float[9];
                        me[0] = -0.1f;
                        me[1] = -0.1f;
                        me[2] = -0.1f;
                        me[3] = -0.1f; //  -0.1 -0.1 -0.1
                        me[4] = 1.8f;  //  -0.1  1.8 -0.1
                        me[5] = -0.1f; //  -0.1 -0.1 -0.1
                        me[6] = -0.1f;
                        me[7] = -0.1f;
                        me[8] = -0.1f;
                        ((anLayer)Layers[ActiveLayerNom]).ApplyEffect(me, 0, 1, false);
                        break;
                    }
                case 6: // ефект "акварель"
                    {
                        float[] me = new float[9];
                        me[0] = 0.5f;
                        me[1] = 1.0f;
                        me[2] = 0.5f;
                        me[3] = 1.0f; //  0.5 1.0 0.5
                        me[4] = 2.0f; //  1.0 2.0 1.0
                        me[5] = 1.0f; //  0.5 1.0 0.5
                        me[6] = 0.5f;
                        me[7] = 1.0f;
                        me[8] = 0.5f;
                        ((anLayer)Layers[ActiveLayerNom]).ApplyEffect(me, 0, 2, true);
                        me[0] = -0.5f;
                        me[1] = -0.5f;
                        me[2] = -0.5f;
                        me[3] = -0.5f; //  -0.5 -0.5 -0.5
                        me[4] = 6.0f;  //  -0.5  6.0 -0.5
                        me[5] = -0.5f; //  -0.5 -0.5 -0.5
                        me[6] = -0.5f;
                        me[7] = -0.5f;
                        me[8] = -0.5f;
                        ((anLayer)Layers[ActiveLayerNom]).ApplyEffect(me, 0, 1, false);
                        break;
                    }
                case 7: // ефект "тиснення"
                    {
                        float[] me = new float[9];
                        me[0] = -1.0f;
                        me[1] = -1.0f;
                        me[2] = -1.0f;
                        me[3] = -1.0f; //  -1.0 -1.0 -1.0
                        me[4] = 8.0f;  //  -1.0  8.0 -1.0
                        me[5] = -1.0f; //  -1.0 -1.0 -1.0
                        me[6] = -1.0f;
                        me[7] = -1.0f;
                        me[8] = -1.0f;
                        ((anLayer)Layers[ActiveLayerNom]).ApplyEffect(me, 0, 2, true);
                        break;
                    }
            }
        }

        public void EffectFilter(int CorrectRed, int CorrectGreen, int CorrectBlue)
        {
            ((anLayer)Layers[ActiveLayerNom]).CorrectRGB(CorrectRed, CorrectGreen, CorrectBlue);
        }


        public void EffectFilter(string FilterFileName) // метод реалізує завантаження фільтру ефекту з файла
        {
            float[] me = new float[9] {1, 1, 1, 1, 1, 1, 1, 1, 1};
            int correction = 0;
            int intensification = 1;
            bool need_correction = false;
            XmlDocument xmlfilter = new XmlDocument();
            xmlfilter.Load(FilterFileName);
            XmlElement fRoot = xmlfilter.DocumentElement;
            foreach (XmlNode filternode in fRoot)
            {
                foreach (XmlNode filterdata in filternode.ChildNodes)
                {
                    if (filterdata.Name == "matrix_0") me[0] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "matrix_1") me[1] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "matrix_2") me[2] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "matrix_3") me[3] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "matrix_4") me[4] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "matrix_5") me[5] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "matrix_6") me[6] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "matrix_7") me[7] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "matrix_8") me[8] = Convert.ToSingle(filterdata.InnerText);
                    if (filterdata.Name == "correction") correction = Convert.ToInt16(filterdata.InnerText);
                    if (filterdata.Name == "intensification") intensification = Convert.ToInt16(filterdata.InnerText);
                    if (filterdata.Name == "need_correction") need_correction = Convert.ToBoolean(filterdata.InnerText);
                }
                ((anLayer)Layers[ActiveLayerNom]).ApplyEffect(me, correction, intensification, need_correction);
            }
        }
    }
}
