#include <iostream>
#include <cstdio>

using namespace std;

int main() {
    int x;

    // Načtení celého kladného čísla od uživatele
    cout << "Zadejte cele kladne cislo: ";
    cin >> x;

    // Inicializace proměnných pro počet cifer a součet cifer
    int pocet_cifer = 0;
    int soucet_cifer = 0;
    int kopie_x = x;

    // Spočítání počtu cifer a součet cifer čísla x
    while (kopie_x > 0) {
        soucet_cifer += kopie_x % 10;
        kopie_x /= 10;
        pocet_cifer++;
    }

    // Spočítání aritmetického průměru
    double prumer = (double)soucet_cifer / pocet_cifer;

    // Výpis aritmetického průměru pomocí printf
    printf("Aritmeticky prumer cifer cisla %d je: %.3f\n", x, prumer);

    return 0;
}
