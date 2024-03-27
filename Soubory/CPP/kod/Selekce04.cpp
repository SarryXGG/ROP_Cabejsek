#include <iostream>

using namespace std;

int main() {
    double x, y;

    // Načtení dvou reálných čísel od uživatele
    cout << "Zadejte dve realna cisla oddelena mezerou: ";
    cin >> x >> y;

    // Výpočet hodnoty výrazu 1/(x*y)
    double vysledek = 1.0 / (x * y);

    // Výpis výsledku
    cout << "Hodnota vyrazu 1/(x*y) je: " << vysledek << endl;

    return 0;
}
