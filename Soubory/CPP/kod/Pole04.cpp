#include <iostream>
#include <cstdlib> // pro funkci rand()

using namespace std;

int main() {
    int n = 0;

    // Načtení celého čísla n
    cout << "Zadejte pocet prvku pole: ";
    cin >> n;

    // Vytvoření pole pro n celých čísel
    int* pole = new int[n];

    // Generování náhodných čísel do pole v intervalu 1 až 10
    cout << "Vygenerovane pole: ";
    for (int i = 0; i < n; ++i) {
        pole[i] = rand() % 10 + 1; // Náhodné číslo v intervalu 1 až 10
        cout << pole[i] << " ";
    }
    cout << endl;

    // Zjistění, zda existuje prvek pole dělitelný posledním prvkem
    bool nalezeno = false;
    for (int i = 0; i < n - 1; ++i) {
        if (pole[i] % pole[n - 1] == 0) {
            cout << "Prvni prvek pole dělitelný poslednim prvkem: " << pole[i] << endl;
            nalezeno = true;
            break; // Zkrácení běhu programu, pokud byl nalezen první prvek splňující podmínku
        }
    }

    // Pokud nebyl nalezen žádný prvek pole dělitelný posledním prvkem
    if (!nalezeno) {
        cout << "Zadny prvek pole neni dělitelný poslednim prvkem." << endl;
    }

    // Uvolnění paměti po použití pole
    delete[] pole;

    return 0;
}

