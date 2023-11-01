int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 12;
int b = 32;
int c = 42;
int d = 21;
int e = 67;
int f = 84;
int g = 45;
int h = 58;
int i = 48;

// int max1 = Max(a, b, c);
// int max2 = Max(d, e, f);
// int max3 = Max(g, h, i);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a, b, c),
    Max(d, e, f),
    Max(g, h, i));

// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// if (f > max) max = f;
// if (g > max) max = g;
// if (h > max) max = h;
// if (i > max) max = i;

Console.WriteLine(max);