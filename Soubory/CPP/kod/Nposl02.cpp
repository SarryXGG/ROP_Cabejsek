#include <iostream>

using namespace std;

int main() {
    int n;

    // Načtení celého čísla n
    cout << "Zadejte pocet prvku posloupnosti: ";
    cin >> n;

    // Vytvoření proměnné pro součet prvků
    int soucet = 0;

    // Načtení prvků posloupnosti a výpočet součtu
    int i = 0;
    char volba;
    cout << "Vyberte typ cyklu pro vypocet souctu (w - while, d - do while, f - for): ";
    cin >> volba;

    switch (volba) {
    case 'w':
    case 'W':
        while (i < n) {
            int prvek;
            cout << "Zadejte " << i + 1 << ". prvek posloupnosti: ";
            cin >> prvek;
            soucet += prvek;
            i++;
        }
        break;
    case 'd':
    case 'D':
        do {
            int prvek;
            cout << "Zadejte " << i + 1 << ". prvek posloupnosti: ";
            cin >> prvek;
            soucet += prvek;
            i++;
        } while (i < n);
        break;
    case 'f':
    case 'F':
        for (i = 0; i < n; ++i) {
            int prvek;
            cout << "Zadejte " << i + 1 << ". prvek posloupnosti: ";
            cin >> prvek;
            soucet += prvek;
        }
        break;
    default:
        cout << "Neplatna volba typu cyklu.";
        return 1; // Návratový kód 1 značí chybu
    }

    // Výpis součtu prvků posloupnosti
    cout << "Soucet prvku posloupnosti je: " << soucet << endl;

    return 0;
}
