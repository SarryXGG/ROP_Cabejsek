#include <iostream>

using namespace std;

int main() {
    int a, b, c;

    // Načtení tří čísel od uživatele
    cout << "Zadejte tri cela cisla oddelená mezerou: ";
    cin >> a >> b >> c;

    // Výpočet aritmetického průměru
    double prumer = (a + b + c) / 3.0; // použití desetinného čísla pro zachování přesnosti

    // Výpis výsledku
    cout << "Aritmeticky prumer cisel " << a << ", " << b << " a " << c << " je: " << prumer << endl;

    return 0;
}
