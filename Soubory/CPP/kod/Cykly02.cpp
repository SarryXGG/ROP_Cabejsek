#include <iostream>

using namespace std;

// Funkce pro výpočet mocniny a umocněného na n
int mocnina(int a, int n) {
    // Inicializace proměnné pro výsledek
    int vysledek = 1;

    // Cyklus pro opakované násobení
    for (int i = 0; i < n; i++) {
        vysledek *= a;
    }

    return vysledek;
}

int main() {
    int a, n;

    // Načtení čísel a a n
    cout << "Zadejte cele kladne cislo a: ";
    cin >> a;
    cout << "Zadejte cele nezaporne cislo n: ";
    cin >> n;

    // Výpočet mocniny a umocněného na n
    int vysledek = mocnina(a, n);

    // Výpis výsledku
    cout << "Mocnina " << a << "^" << n << " je: " << vysledek << endl;

    return 0;
}
