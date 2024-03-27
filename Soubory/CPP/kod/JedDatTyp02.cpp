#include <iostream>

using namespace std;

int main() {
    int cislo;
    cout << "Zadejte cele kladne cislo: ";
    cin >> cislo;

    // Kontrola platnosti vstupu (kladné číslo)
    if (cislo < 0) {
        cout << "Zadane cislo neni kladne." << endl;
        return 1; // Návratový kód 1 značí chybu
    }

    // Inicializace proměnné pro ukládání výsledku
    unsigned long long vysledek = 1;

    // Výpočet faktoriálu
    for (int i = 2; i <= cislo; ++i) {
        vysledek *= i;
    }

    // Výpis výsledku
    cout << "Faktorial cisla " << cislo << " je: " << vysledek << endl;

    return 0; // Návratový kód 0 značí úspěšné dokončení programu
}
