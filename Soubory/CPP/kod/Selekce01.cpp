#include <iostream>

using namespace std;

int main() {
    int a, b;

    // Načtení dvou různých celých čísel od uživatele
    cout << "Zadejte prvni cele cislo: ";
    cin >> a;
    cout << "Zadejte druhe cele cislo: ";
    cin >> b;

    // Odečtení menšího čísla od většího
    int vysledek = (a > b) ? (a - b) : (b - a);

    // Výpis výsledku
    cout << "Rozdil mezi cisly je: " << vysledek << endl;

    return 0;
}
