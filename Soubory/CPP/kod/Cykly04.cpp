#include <iostream>

using namespace std;

// Funkce pro výpočet faktoriálu čísla n
unsigned long long faktorial(int n) {
    // Inicializace proměnné pro výsledek
    unsigned long long vysledek = 1;

    // Cyklus pro postupné násobení čísel od 1 do n
    for (int i = 1; i <= n; ++i) {
        vysledek *= i;
    }

    return vysledek;
}

int main() {
    int n;

    // Načtení nezáporného čísla n
    cout << "Zadejte cele nezaporne cislo n: ";
    cin >> n;

    // Výpočet faktoriálu n
    unsigned long long vysledek = faktorial(n);

    // Výpis výsledku
    cout << "Faktorial " << n << "! je: " << vysledek << endl;

    return 0;
}
