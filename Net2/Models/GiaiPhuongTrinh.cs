namespace Net2.Models
{
    public class GiaiPhuongTrinh
    {
        public string GiaiPhuongTrinhBacNhat(string heSoA, string heSoB)
        {
            double a, b, x;
            string message = "";
            a = double.Parse(heSoA);
            b = double.Parse(heSoB);

            if (a == 0)
            {
                if (b != 0)
                {
                    message = "Phuong trinh vo nghiem";
                }
                else
                {
                    message = "Phuong trinh vo so nghiem";
                }
            }
            else
            {
                x = -b / a;
                message = "Phuong trinh co nghiem x = " + x;

            }
            return message;
        }
        public string GiaiPhuongTrinhBacHai(string heSoA, string heSoB, string heSoC)
        {
            double a, b, c, delta, x1, x2;
            string message = "";
            a = double.Parse(heSoA);
            b = double.Parse(heSoB);
            c = double.Parse(heSoC);
            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                message = "Phuong trinh co 2 nghiem la: x1 = " + x1 + " x2 = " + x2;
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                message = "Phuong trinh co nghiem kep: x1 = x2 = " + x1;
            }
            else
            {
                message = ("Phuong trinh vo nghiem!");
            }
            return message;
        }
    }
}
