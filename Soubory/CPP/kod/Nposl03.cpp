#include <iostream>
#include <cstdlib> // pro funkci rand()

using namespace std;

int main() {
    int n;

    // Načtení celého čísla n
    cout << "Zadejte pocet prvku posloupnosti: ";
    cin >> n;

    // Vytvoření pole pro n celých náhodných čísel z intervalu <10;40)
    int* posloupnost = new int[n];

    // Naplnění pole náhodnými čísly z intervalu <10;40)
    for (int i = 0; i < n; ++i) {
        posloupnost[i] = rand() % 31 + 10; // Náhodné číslo v intervalu <10;40)
    }

    // Výběr typu cyklu pro výpočet aritmetického průměru
    char volba;
    cout << "Vyberte typ cyklu pro vypocet aritmetickeho prumeru (w - while, d - do while, f - for): ";
    cin >> volba;

    // Výpočet aritmetického průměru
    double prumer = 0.0;
    switch (volba) {
    case 'w':
    case 'W':
    {
        int i = 0;
        while (i < n) {
            prumer += posloupnost[i];
            i++;
        }
        prumer /= n;
    }
    break;
    case 'd':
    case 'D':
    {
        int i = 0;
        do {
            prumer += posloupnost[i];
            i++;
        } while (i < n);
        prumer /= n;
    }
    break;
    case 'f':
    case 'F':
        for (int i = 0; i < n; ++i) {
            prumer += posloupnost[i];
        }
        prumer /= n;
        break;
    default:
        cout << "Neplatna volba typu cyklu.";
        delete[] posloupnost; // Uvolnění paměti
        return 1; // Návratový kód 1 značí chybu
    }

    // Výpis aritmetického průměru
    cout << "Aritmeticky prumer prvku posloupnosti je: " << prumer << endl;

    // Uvolnění paměti po použití pole
    delete[] posloupnost;

    return 0;
}
