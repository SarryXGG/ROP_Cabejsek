#include <iostream>

using namespace std;

int main() {
    int cislo;
    long long soucin = 1; // Používáme long long pro součin, aby bylo možné pracovat s většími hodnotami

    // Načítání čísel a výpočet součinu
    cout << "Zadejte posloupnost nenulových čísel zakončenou nulou:" << endl;
    cin >> cislo;

    while (cislo != 0) {
        soucin *= cislo;
        cin >> cislo;
    }

    // Výpis součinu
    cout << "Soucin vsech prvku posloupnosti je: " << soucin << endl;

    return 0;
}
