using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        // переменные для расчетов
        double Chord, Angle, zz;
        int NPoint;
        string txtProfile;
        // массивы значений для точек кривых
        double[] high_x; 
        double[] high_y; 
        double[] low_x; 
        double[] low_y; 
        double[] c; 
        double[] x; 

        double cx0, cy0, mass; // координаты центра тяжести, масса фигуры
        //string mes1, mes2, mes3;
        string fn; // имя файла

        // обработка событий формы
        public Form1()
        {
            InitializeComponent();          
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "текст (*.txt)|*.txt";
            saveFileDialog1.Title = "Сохранение файла " + textProfile.Text + ".txt";
            fn = "";
            try
            {
                NPoint = Convert.ToInt16(textNPoint.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Внимание", "Ошибка в поле ввода количества точек! " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // инициализация массива значений для кривых
            high_x = new double[NPoint];
            high_y = new double[NPoint];
            low_x = new double[NPoint];
            low_y = new double[NPoint];
            c = new double[NPoint];
            x = new double[NPoint];

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //int result = 0;


            // отобразить диалог Сохранить
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // отобразить имя файла в заголовке окна
                saveFileDialog1.Title = txtProfile;
                saveFileDialog1.FileName = txtProfile + ".txt";
                fn = saveFileDialog1.FileName;
                // this.Text = fn;
            }


            // сохранить файл
            if (fn != string.Empty)
            {
                try
                {
                    // получим информацию о файле fn
                    System.IO.FileInfo fi = new System.IO.FileInfo(fn);
                    // поток для записи (перезаписываем файл)
                    System.IO.StreamWriter sw = fi.CreateText();
                    // записываем данные

                    NumberFormatInfo myformat = new CultureInfo("en-US", false).NumberFormat;
                    myformat.NumberDecimalSeparator = ".";

                    double a = zz;
                    for (int i = NPoint - 1; i >= 0; i--)
                    {

                        //a = Convert.ToDouble(high_x.GetValue(i));
                        sw.Write(high_x[i].ToString("000.000", myformat) + "mm");
                        sw.Write('\t'); // знак табуляции между числами
                        //a = Convert.ToDouble(high_y.GetValue(i));
                        sw.Write(high_y[i].ToString("000.000", myformat) + "mm");
                        sw.Write('\t'); // знак табуляции между числами
                        //a = zz;
                        sw.WriteLine(a.ToString("000.000", myformat) + "mm");
                    }

                    for (int i = 1; i < NPoint; i++)
                    {

                        //a = Convert.ToDouble(low_x.GetValue(i));
                        sw.Write(low_x[i].ToString("000.000", myformat) + "mm");
                        sw.Write('\t'); // знак табуляции между числами
                        //a = Convert.ToDouble(low_y.GetValue(i));
                        sw.Write(low_y[i].ToString("000.000", myformat) + "mm");
                        sw.Write('\t'); // знак табуляции между числами
                        //a = zz;
                        sw.WriteLine(a.ToString("000.000", myformat) + "mm");
                    }


                    // закрываем поток
                    sw.Close();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "NkEdit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // проверка введенных данных
            try
            {
                Chord = Convert.ToDouble(textChord.Text);
                Angle = -Convert.ToDouble(textAngle.Text)*3.14159265/180;
                //NPoint = Convert.ToInt16(textNPoint.Text);
                zz = Convert.ToDouble(txtz.Text);

                txtProfile = textProfile.Text;
            }
            catch (FormatException ex)
            {
                if ((textChord.Text.Length == 0) || (textAngle.Text.Length == 0) || /*(textNPoint.Text.Length == 0) ||*/ (textProfile.Text.Length == 0))
                    MessageBox.Show("Заполните пустые поля." , "Внимание! "+ ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                    MessageBox.Show("Ошибка в полях." , "Ошибка! "+ ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (NPoint >= 250) MessageBox.Show("Задайте меньшее количество расчетных точек.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // перевод угла из радиан в градусы
            // положительное направление - вращение системы координат по часовой стрелке
            //Angle = -Angle * 180 / 3.14159265; 

            // нахождение параметров профиля
            double pos, camber, thik, t;
            int p;
            p = Convert.ToInt32(txtProfile);
            camber = (double) (p / 1000) * 0.01; // сред линия
            pos = (double) (p % 1000 / 100) * 0.1; // положение макс толщины
            thik = (double)(p % 100) * 0.01; // толщина профиля
            double pos1 = pos * Chord;          
          
                // промежуточные переменные для координат
                double xc, yc; 
                double ee;
                double dcc;
                double teta;
                double yh, yl, xh, xl;
            // нахождение координат верхней и нижней части профиля
            for (int i = 0; i < NPoint; i++)
            {
                xc = Chord * i / NPoint; // координата Х
                // координата У для средней линии
                ee = xc / Chord;
                if (xc < pos1) yc = camber * xc * (2 * pos - ee) / (pos * pos);
                else if (pos1==0) yc=0;
                else yc = camber * (Chord -xc) * (1+ee-2*pos) / ((1 - pos) * (1 - pos));
                
                // толщины профиля
                t = 5 * thik* Chord *(0.2969*Math.Sqrt(ee)-0.126*ee-0.3516*ee*ee+0.2843*ee*ee*ee-0.1015*ee*ee*ee*ee);
                // производная в точке Х
                if (xc < pos1) dcc = 2 * camber * (1 - ee / pos) / pos;
                else if (pos1 == 0) dcc = 2 * camber;
                else dcc = 2 * camber * (pos - ee) / ((1 - pos) * (1 - pos));
                teta = Math.Atan(dcc);
                // верхняя и нижняя кромки профиля
                xh = xc - t * Math.Sin(teta);
                xl = xc + t * Math.Sin(teta);
                yh = yc + t * Math.Cos(teta);
                yl = yc - t * Math.Cos(teta);
                // записываем результы расчета в массив
                c[i] = yc; // координата средней линии в массив
                x[i] = xc; // координата Х в массив
                //yt.SetValue(t, i);
                high_x[i]=xh;
                high_y[i] = yh;
                low_x[i] = xl;
                low_y[i] = yl;  
            }
            
            // вычисляем центр масс фигуры
            double dx, dy, ss1, ss2;
            double cxs, cys, ss;
            double cx1, cy1, cx2, cy2;
            // обнуляем сумматоры
            cx1 = 0;
            cx2 = 0;
            cy1 = 0;
            cy2 = 0;
            ss1 = 0;
            ss2 = 0;
            // вычисляем центр масс профиля
            for (int i=0; i<NPoint-1; i++)
            {
                // координаты центра масс элементарной трапеции
                dx = high_x[i + 1] - high_x[i];
                dy = high_y[i + 1] - high_y[i];
                ss = dx * high_y[i] + 0.5 * dx * dy;
                cxs = (high_x[i] + 0.5 * dx) * dx * high_y[i] + 0.5 * dx * dy * (high_x[i] + 2 * dx / 3);
                cys = 0.5 * high_y[i] * high_y[i] * dx + 0.5 * dx * dy * (high_y[i] + dy / 3);
                
                ss1 = ss1 + ss;
                cx1 = cx1 + cxs;
                cy1 = cy1 + cys;

                dx = low_x[i + 1] - low_x[i];
                dy = low_y[i + 1] - low_y[i];
                ss = dx * low_y[i] + 0.5 * dx * dy;
                cxs = (low_x[i] + 0.5 * dx) * dx * low_y[i] + 0.5 * dx * dy * (low_x[i] + 2 * dx / 3);
                cys = 0.5 * low_y[i] * low_y[i] * dx + 0.5 * dx * dy * (low_y[i] + dy / 3);
                
                ss2 = ss2 + ss;
                cx2 = cx2 + cxs;
                cy2 = cy2 + cys;
            }
            
            /*
            mes1 = Convert.ToString(ss1) + ' ' + Convert.ToString(cx1) + ' ' + Convert.ToString(cy1);
            mes2 = Convert.ToString(ss2) + ' ' + Convert.ToString(cx2) + ' ' + Convert.ToString(cy2);
            mes3 = Convert.ToString(ss1-ss2)+' '+Convert.ToString((cx1*ss1-cx2*ss2)/(ss1-ss2))+' '+Convert.ToString((cy1*ss1-cy2*ss2)/(ss1-ss2));
             */
            mass = ss1 - ss2;
            cx0 = (cx1  - cx2 ) / mass;
            cy0 = (cy1  - cy2 ) / mass;

            // переносим начало координат в центр масс профиля
            for (int i = 0; i<NPoint; i++)
            {
                high_x[i] = high_x[i] - cx0;
                low_x[i] = low_x[i] - cx0;
                high_y[i] = high_y[i] - cy0;
                low_y[i] = low_y[i] - cy0;
            }

            // поворачиваем оси координат на заданный угол

            for (int i = 0; i < NPoint; i++)
            {
                dx = high_x[i] * Math.Cos(Angle) + high_y[i] * Math.Sin(Angle);
                dy = -high_x[i] * Math.Sin(Angle) + high_y[i] * Math.Cos(Angle);
                high_x[i] = dx;
                high_y[i] = dy;

                dx = low_x[i] * Math.Cos(Angle) + low_y[i] * Math.Sin(Angle);
                dy = -low_x[i] * Math.Sin(Angle) + low_y[i] * Math.Cos(Angle);
                low_x[i] = dx;
                low_y[i] = dy;
            }

        }
    }
}
