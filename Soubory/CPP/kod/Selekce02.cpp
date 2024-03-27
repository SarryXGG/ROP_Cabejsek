#include <iostream>

using namespace std;

int main() {
    double a, b, c;

    // Načtení tří čísel od uživatele
    cout << "Zadejte tri cisla oddelena mezerou: ";
    cin >> a >> b >> c;

    // Pokud je první číslo nezáporné, spočítej aritmetický průměr
    if (a >= 0) {
        double prumer = (a + b + c) / 3.0;
        cout << "Aritmeticky prumer je: " << prumer << endl;
    }
    // Jinak spočítej součin čísel
    else {
        double soucin = a * b * c;
        cout << "Soucin je: " << soucin << endl;
    }

    return 0;
}
