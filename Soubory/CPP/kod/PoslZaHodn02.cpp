#include <iostream>

using namespace std;

int main() {
    int cislo;
    int soucet = 0;
    char volba;

    // Načtení posloupnosti čísel od uživatele
    cout << "Zadejte posloupnost kladnych cisel zakoncenou zapornym cislem: ";

    // Načtení volby typu cyklu od uživatele
    cout << "Zvolte typ cyklu (w - while, d - do while, f - for): ";
    cin >> volba;

    // Výpočet součtu prvků posloupnosti podle zvoleného typu cyklu
    switch (volba) {
    case 'w': // Cyklus while
        cout << "Pomoci cyklu while:" << endl;
        cin >> cislo;
        while (cislo > 0) {
            soucet += cislo;
            cin >> cislo;
        }
        break;
    case 'd': // Cyklus do while
        cout << "Pomoci cyklu do while:" << endl;
        do {
            cin >> cislo;
            if (cislo > 0) {
                soucet += cislo;
            }
        } while (cislo > 0);
        break;
    case 'f': // Cyklus for
        cout << "Pomoci cyklu for:" << endl;
        for (cin >> cislo; cislo > 0; cin >> cislo) {
            soucet += cislo;
        }
        break;
    default:
        cout << "Neplatna volba." << endl;
        return 1;
    }

    // Výpis součtu prvků posloupnosti
    cout << "Soucet prvku posloupnosti je: " << soucet << endl;

    return 0;
}
