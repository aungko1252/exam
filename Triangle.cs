Triangle.cs

class Triangle
{
    private double side1, side2, side3;

    public Triangle()
    {
        side1 = 3;
        side2 = 4;
        side3 = 5;
    }

    public Triangle(double s1, double s2, double s3)
    {
        side1 = s1;
        side2 = s2;
        side3 = s3;
    }

    public double GetPerimeter()
    {
        return side1 + side2 + side3;
    }

    public double GetArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public void ShowData()
    {
        MessageBox.Show($"Area = {GetArea()}\nPerimeter = {GetPerimeter()}", "Triangle Properties");
    }
}



___________________________________________________________________________

Form1.cs

public Form1()
{
    InitializeComponent();
}

private void btnCalculate_Click(object sender, EventArgs e)
{
    double side1 = double.Parse(textBox1.Text);
    double side2 = double.Parse(textBox2.Text);
    double side3 = double.Parse(textBox3.Text);

    Triangle triangle = new Triangle(side1, side2, side3);

    MessageBox.Show($"Area: {triangle.GetArea()}\nPerimeter: {triangle.GetPerimeter()}", "Triangle Properties");

    Triangle t1 = new Triangle();  // Default triangle
    Triangle t2 = new Triangle(6, 8, 13);  // Custom triangle
    Triangle t3 = new Triangle(5, 10, 13); // Another triangle

    t1.ShowData();
    t2.ShowData();
    t3.ShowData();
}
