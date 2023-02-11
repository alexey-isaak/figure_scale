void scale(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double k_scale )
{
    double new_x1 = x1 * k_scale;
    double new_y1 = y1 * k_scale;
    double new_x2 = x2 * k_scale;
    double new_y2 = y2 * k_scale;
    double new_x3 = x3 * k_scale;
    double new_y3 = y3 * k_scale;
    double new_x4 = x4 * k_scale;
    double new_y4 = y4 * k_scale;

    Console.WriteLine("Координаты новой фигуры: " + "(" + new_x1 + "," + new_y1 + ")"  + " " + "(" + new_x2 + "," + new_y2 + ")" + " " + "(" + new_x3 + "," + new_y3 + ")" + " " + "(" + new_x4 + "," + new_y4 + ")");
    
}

Console.WriteLine("Введите координаты вершин фигуры в одну строку, пример: (x1,y1) (x2,y2) (x3,y3) (x4,y4)");
string koord_figure = Convert.ToString(Console.ReadLine())!;

Console.WriteLine("Введите коэффициент масштабирования:");
double k_scale = double.Parse(Console.ReadLine());

double x1 = (double)Char.GetNumericValue(koord_figure[1]);
double y1 = (double)Char.GetNumericValue(koord_figure[3]);
double x2 = (double)Char.GetNumericValue(koord_figure[7]);
double y2 = (double)Char.GetNumericValue(koord_figure[9]);
double x3 = (double)Char.GetNumericValue(koord_figure[13]);
double y3 = (double)Char.GetNumericValue(koord_figure[15]);
double x4 = (double)Char.GetNumericValue(koord_figure[19]);
double y4 = (double)Char.GetNumericValue(koord_figure[21]);

scale(x1, y1, x2, y2, x3, y3, x4, y4, k_scale);
