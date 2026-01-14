static void tambah (int a, int b)
{
    int c = 0;


    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

static void kurang (int a, int b)
{
    int c = 0;

        
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

static void kali (int a, int b)
{
    int c = 0;


    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

static void bagi (int a, int b)
{
    int c = 0;


    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(10, 2);

tambah(968, 1);

kurang(970, 1);

kali(10, 10);

bagi(100, 10);