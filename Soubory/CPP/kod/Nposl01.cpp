// ZRS 02.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>
using namespace std;

int main()
{
    srand((unsigned)time(NULL));


    int n;
    cout << "*********************************\n";
    cout << "Zadejte pocet prvku v posloupnosti: ";
    cin >> n;

    char znak;
    do
    {
        

        cout << "\nW - while, D - Do while, F - for, K - Konec\n";
        cin >> znak;

        switch (znak)
        {
        case 'W':
        {
            double soucet = 0;
            int i = 0;

            while (i < n)
            {
                double x = 10 + (100 - 10) * (double)rand() / (RAND_MAX + 1);
                cout << endl << x;
                soucet += x;
                i++;
            }

            cout << "\nVysledek je " << soucet << endl << endl;
            break;
        }
        case 'D':
        {
            double soucet = 0;
            int i = 0;

            if (n > 0)
            {
                do
                {
                    double x = 10 + (100 - 10) * (double)rand() / (RAND_MAX + 1);
                    cout << endl << x;
                    soucet += x;
                    i++;
                } while (i < n);

                cout << "\nVysledek je " << soucet << endl << endl;
            }

            break;
        }
        case 'F':
        {
            double soucet = 0;

            for (int i = 0; i < n; i++)
            {
                double x = 10 + (100 - 10) * (double)rand() / (RAND_MAX + 1);
                cout << endl << x;
                soucet += x;
            }

            cout << "\nVysledek je " << soucet << endl << endl;

            break;
        }
        case 'K':
        {
            cout << "\nKonec programu.";
            break;
        }
        default:
        {
            break;
        }
        }

    } while (znak != 'K');

    getchar();
    getchar();
}