static void Main(string[] args)
{   // function does thingy
    funcy();
    int sum = addition(3, 5);
    Console.WriteLine(sum);
    string text = hi("Hello World");
    Console.WriteLine(text);
    int[] nums = { 1, 2, 3, 4, 5, 6 };
    double sum = average(nums);
    Console.WriteLine(sum);
}

static void funcy()
{
    Console.WriteLine("Hello World!");
}

static void kthxbai(); // ....

static int addition(int numb1, int num2)
{
    int sum = num1 + num2;
    return sum;
}