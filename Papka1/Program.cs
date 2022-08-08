int a1 = 1;
int b1 = 2;
int c1 = 3;
int a2 = 4;
int b2 = 5;
int c2 = 6;
int a3 = 7;
int b3 = 8;
int c3 = 9;


int max = a1;
if (max < b1) max = b1;
if (max < c1) max = c1;
if (max < a2) max = a2;
if (max < b2) max = b2;
if (max < c2) max = c2;
if (max < a3) max = a3;
if (max < b3) max = b3;
if (max < c3) max = c3;

    Console.WriteLine(max);
